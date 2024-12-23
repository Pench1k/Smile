using BD.DBContext;
using BD.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MVC.Controllers
{
    public class MakeAnAppointmentController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public MakeAnAppointmentController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Authorize]
        [HttpGet("Study/Schedules/{id}")]
        public IActionResult Index(string id)
        {
            var stomatologiay = _dbContext.Stomatology.ToList();


            return View(stomatologiay);
        }
        [HttpGet("/Clinic/Doctor")]
        public IActionResult GetDoctorsByClinic(int clinicId)
        {
            var doctors = _dbContext.Doctor.Include(d => d.Workers).ThenInclude(w => w.User)
                .Where(d => d.Workers.StomatologyId == clinicId)
                .ToList();
            return Json(doctors);
        }
        [HttpGet("/Doctor/Zapis")]
        public IActionResult GetDoctorZapis(int doctorId)
        {
            var reception = _dbContext.Reception
                .Include(r => r.WorkingHouseDoctor) // Включаем связанные данные для WorkingHouseDoctor
                .ThenInclude(wd => wd.Doctor) // Включаем связанные данные для Doctor через WorkingHouseDoctor
                .Include(wr => wr.WorkingHouseDoctor) // Включаем WorkingHouseDoctor
                .ThenInclude(wd => wd.WorkingHours) // Включаем связанные данные для WorkingHours
                .Where(r => r.WorkingHouseDoctor.DoctorId == doctorId && r.DateTimeReception >= DateTime.Now && r.PatientId == null).OrderBy(rr => rr.DateTimeReception)
                .ToList();
            return Json(reception);
        }
        [HttpPut("/Doctor/Reception/{id}")]
        public IActionResult GetReception(int receptionId, string userId)
        {
            var patient = _dbContext.Patient.Where(p => p.UserId == userId).FirstOrDefault();
            var reseption = _dbContext.Reception.Where(r => r.Id == receptionId).FirstOrDefault();
            reseption.PatientId = patient.Id;
            reseption.Status = BD.Entity.AttendanceStatus.Обрабатывается;
            _dbContext.Reception.Update(reseption);
            _dbContext.SaveChanges();
            return Ok();
        }
        [HttpGet("Admin/Schedules/{id}")]
        public IActionResult Admin(string id)
        {
            
            var stomatologiay = _dbContext.Stomatology.ToList();


            return View(stomatologiay);
        }

        [HttpGet("/Admin/Zapis")]
        public IActionResult GetDoctorZapisAdmin(int doctorId)
        {
            var reception = _dbContext.Reception
                .Include(r => r.WorkingHouseDoctor) // Включаем связанные данные для WorkingHouseDoctor
                .ThenInclude(wd => wd.Doctor) // Включаем связанные данные для Doctor через WorkingHouseDoctor
                .Include(wr => wr.WorkingHouseDoctor) // Включаем WorkingHouseDoctor
                .ThenInclude(wd => wd.WorkingHours) // Включаем связанные данные для WorkingHours
                .Where(r => r.WorkingHouseDoctor.DoctorId == doctorId && r.DateTimeReception >= DateTime.Now && r.PatientId != null && r.Status == BD.Entity.AttendanceStatus.Обрабатывается).OrderBy(rr => rr.DateTimeReception)
                .ToList();
            return Json(reception);
        }

        [HttpPut("/Admin/Reception")]
        public IActionResult GetReceptionAdmin(int receptionId)
        {
          
            var reseption = _dbContext.Reception.Where(r => r.Id == receptionId).FirstOrDefault();
            reseption.Status = BD.Entity.AttendanceStatus.Принята;
            _dbContext.Reception.Update(reseption);
            _dbContext.SaveChanges();
            return Ok();
        }


        [HttpGet("/Doctor/Reception/{id}")]
        public IActionResult Doctor(string id)
        {
            var doctors = _dbContext.Doctor
    .Include(d => d.Workers) // Включаем связанные данные для Workers
    .ThenInclude(w => w.User) // Включаем связанные данные для User через Workers
    .Where(d => d.Workers.UserId == id) // Фильтруем по полю в сущности Worker
    .FirstOrDefault();
            var reception = _dbContext.Reception
                .Include(r => r.Patient).ThenInclude(p => p.User)
                            .Include(r => r.WorkingHouseDoctor) // Включаем связанные данные для WorkingHouseDoctor
                            .ThenInclude(wd => wd.Doctor) // Включаем связанные данные для Doctor через WorkingHouseDoctor
                            .Include(wr => wr.WorkingHouseDoctor) // Включаем WorkingHouseDoctor
                            .ThenInclude(wd => wd.WorkingHours) // Включаем связанные данные для WorkingHours
                            .Where(r => r.WorkingHouseDoctor.DoctorId == doctors.Id && r.DateTimeReception >= DateTime.Now && r.PatientId != null && r.Status == BD.Entity.AttendanceStatus.Принята).OrderBy(rr => rr.DateTimeReception)
                            .ToList();
           return View(reception);
        }

    }
}

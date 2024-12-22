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
            var doctors = _dbContext.WorkingHouseDoctor.Include(wr => wr.WorkingHours).Include(d => d.Doctor)
                .Where(d => d.DoctorId == doctorId)
                .ToList();
            return Json(doctors);
        }
    }
}

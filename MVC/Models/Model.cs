using BD.Entity;

namespace MVC.Models
{
    public class Model
    {
        public int Id { get; set; }
        public int? WorkingHouseDoctorId { get; set; }
        public WorkingHouseDoctor? WorkingHouseDoctor { get; set; }

        public int? PatientId { get; set; }
        public Patient? Patient { get; set; }
        public DateTime? DateTimeReception { get; set; }

        //Статус явки
        public AttendanceStatus? Status { get; set; }

        public string? Recommendations { get; set; }

      
    }

    public enum AttendanceStatus
    {
        НетЗаписи,
        Обрабатывается,
        Принята,
    }
}


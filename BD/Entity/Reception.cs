using System.Data;

namespace BD.Entity
{
    public class Reception
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
        Обрабатывается,
        Принята,
    }
}

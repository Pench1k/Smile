namespace BD.Entity
{
    public class WorkingHouseDoctor
    {
        public int Id { get; set; }

        public int? WorkingHouseId { get; set; }
        public WorkingHours? WorkingHours { get; set; }

        public int? DoctorId {  get; set; }
        public Doctor? Doctor { get; set; }
    }
}

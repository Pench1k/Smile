namespace BD.Entity
{
    public class Doctor
    {
        public int Id { get; set; }

        public int? SpecializationId { get; set; }
        public Specialization? Specialization { get; set; }
        
        public int? OfficeId { get; set; }
        public Office? Office { get; set; }
        public int? WorkersId {  get; set; } 
        public Workers? Workers { get; set; }
    }
}

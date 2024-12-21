namespace BD.Entity
{
    public class Workers
    {
        public int Id { get; set; }

        // Номер страховки
        public string? InsuranceNumber {  get; set; }

        // Номер трудовой
        public string? LaborNumber { get; set; }

        //Образование

        public string? Education { get; set; }

        //Дата трудоустройсва

        public DateTime? DateOfEmployment { get; set; }

        public int? StomatologyId { get; set; }
        public Stomatology? Stomatology { get; set; }

        public string? UserId { get; set; }
        public User? User { get; set; }
    }
}

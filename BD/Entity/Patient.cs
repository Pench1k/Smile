namespace BD.Entity
{
    public class Patient
    {
        public int Id { get; set; }

        //Место работы
        public string? PlaceOfWork { get; set; }

        public string? UserId { get; set; }
        public User? User { get; set; }
    }
}

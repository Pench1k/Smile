namespace BD.Entity
{
    public class Stomatology
    {
        public int Id { get; set; } 

        //Номер
        public string? Number { get; set; }

        //Название
        public string? Name { get; set; }

        //Город
        public string? City { get; set; }

        //Район
        public string? District { get; set; }

        // Улица
        public string? Street { get; set; }

        //Дом
        public string? House { get; set; }

    }
}

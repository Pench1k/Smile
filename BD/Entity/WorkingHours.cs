namespace BD.Entity
{
    public class WorkingHours
    {
        public int Id { get; set; }

        //День недели
        public int? DayOfTheWeek { get; set; }

        //Начало приема
        public TimeSpan? Start { get; set; }

        //Конец приема
        public TimeSpan? End { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;

namespace BD.Entity
{
    public class User : IdentityUser
    {
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? MiddleName { get; set; }

        //Пол
        public TypeGender? Gender { get; set; }

        //День рождение
        public DateTime? DateOfBirthday { get; set; }

        //Место проживание
        public string? PlaceOfResidence { get; set; }
    }
    public enum TypeGender
    {
        М,
        Ж
    }
}

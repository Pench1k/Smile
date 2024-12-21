using BD.DBContext;
using BD.Entity;

namespace MVC
{
    public class Seed
    {
        private readonly ApplicationDbContext _context;

        public Seed(ApplicationDbContext context)
        {
            _context = context;
        }
        public void SeedDataContext()
        {
            //Добавляем стоматологии
            if (!_context.Stomatology.Any())
            {
                var stomatology = new List<Stomatology>
                {
                    new Stomatology
                    {
                        Number = "001",
                        Name = "Стоматология на Мира",
                        City = "Гомель",
                        District = "Центральный",
                        Street = "Улица Мира",
                        House = "15"
                    },
                    new Stomatology
                    {
                        Number = "002",
                        Name = "Стоматология на Свердлова",
                        City = "Гомель",
                        District = "Железнодорожный",
                        Street = "Улица Свердлова",
                        House = "23"
                    },
                    new Stomatology
                    {
                        Number = "003",
                        Name = "Стоматология на Ленина",
                        City = "Минск",
                        District = "Первомайский",
                        Street = "Улица Ленина",
                        House = "8"
                    }
                };
                _context.Stomatology.AddRange();
                _context.SaveChanges();
            }
            

            // Добавление пользователей
            if (!_context.Users.Any())
            {
                var users = new List<User>
                {
                    new User
                    {
                        UserName = "ivan.petrov",
                        Email = "ivan.petrov@example.com",
                        Surname = "Петров",
                        Name = "Иван",
                        MiddleName = "Алексеевич",
                        Gender = TypeGender.М,
                        DateOfBirthday = new DateTime(1990, 1, 15),
                        PlaceOfResidence = "Минск, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "olga.kovaleva",
                        Email = "olga.kovaleva@example.com",
                        Surname = "Ковалева",
                        Name = "Ольга",
                        MiddleName = "Сергеевна",
                        Gender = TypeGender.Ж,
                        DateOfBirthday = new DateTime(1992, 6, 25),
                        PlaceOfResidence = "Гомель, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "alexandr.ivanov",
                        Email = "alexandr.ivanov@example.com",
                        Surname = "Иванов",
                        Name = "Александр",
                        MiddleName = "Викторович",
                        Gender = TypeGender.М,
                        DateOfBirthday = new DateTime(1985, 11, 5),
                        PlaceOfResidence = "Гродно, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "natalia.smirnova",
                        Email = "natalia.smirnova@example.com",
                        Surname = "Смирнова",
                        Name = "Наталья",
                        MiddleName = "Владимировна",
                        Gender = TypeGender.Ж,
                        DateOfBirthday = new DateTime(1988, 8, 13),
                        PlaceOfResidence = "Брест, Беларусь",
                        EmailConfirmed = true
                    },

                    new User
                    {
                        UserName = "sergey.popov",
                        Email = "sergey.popov@example.com",
                        Surname = "Попов",
                        Name = "Сергей",
                        MiddleName = "Петрович",
                        Gender = TypeGender.М,
                        DateOfBirthday = new DateTime(1991, 4, 8),
                        PlaceOfResidence = "Минск, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "anna.sokolova",
                        Email = "anna.sokolova@example.com",
                        Surname = "Соколова",
                        Name = "Анна",
                        MiddleName = "Игоревна",
                        Gender = TypeGender.Ж,
                        DateOfBirthday = new DateTime(1993, 2, 22),
                        PlaceOfResidence = "Витебск, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "dmitry.belov",
                        Email = "dmitry.belov@example.com",
                        Surname = "Белов",
                        Name = "Дмитрий",
                        MiddleName = "Геннадиевич",
                        Gender = TypeGender.М,
                        DateOfBirthday = new DateTime(1987, 9, 3),
                        PlaceOfResidence = "Могилев, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "maria.voronina",
                        Email = "maria.voronina@example.com",
                        Surname = "Воронина",
                        Name = "Мария",
                        MiddleName = "Александровна",
                        Gender = TypeGender.Ж,
                        DateOfBirthday = new DateTime(1994, 12, 30),
                        PlaceOfResidence = "Гомель, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "evgeny.karpov",
                        Email = "evgeny.karpov@example.com",
                        Surname = "Карпов",
                        Name = "Евгений",
                        MiddleName = "Сергеевич",
                        Gender = TypeGender.М,
                        DateOfBirthday = new DateTime(1986, 7, 18),
                        PlaceOfResidence = "Минск, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "tatiana.ivanova",
                        Email = "tatiana.ivanova@example.com",
                        Surname = "Иванова",
                        Name = "Татьяна",
                        MiddleName = "Юрьевна",
                        Gender = TypeGender.Ж,
                        DateOfBirthday = new DateTime(1990, 11, 10),
                        PlaceOfResidence = "Бобруйск, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "alexey.morozov",
                        Email = "alexey.morozov@example.com",
                        Surname = "Морозов",
                        Name = "Алексей",
                        MiddleName = "Анатольевич",
                        Gender = TypeGender.М,
                        DateOfBirthday = new DateTime(1982, 5, 25),
                        PlaceOfResidence = "Гродно, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "elena.kuzmina",
                        Email = "elena.kuzmina@example.com",
                        Surname = "Кузьмина",
                        Name = "Елена",
                        MiddleName = "Владимировна",
                        Gender = TypeGender.Ж,
                        DateOfBirthday = new DateTime(1989, 3, 14),
                        PlaceOfResidence = "Минск, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "pavel.mikhaylov",
                        Email = "pavel.mikhaylov@example.com",
                        Surname = "Михайлов",
                        Name = "Павел",
                        MiddleName = "Николаевич",
                        Gender = TypeGender.М,
                        DateOfBirthday = new DateTime(1984, 10, 30),
                        PlaceOfResidence = "Могилев, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "daria.karpova",
                        Email = "daria.karpova@example.com",
                        Surname = "Карпова",
                        Name = "Дарья",
                        MiddleName = "Александровна",
                        Gender = TypeGender.Ж,
                        DateOfBirthday = new DateTime(1995, 1, 18),
                        PlaceOfResidence = "Гомель, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "vladimir.korolev",
                        Email = "vladimir.korolev@example.com",
                        Surname = "Королев",
                        Name = "Владимир",
                        MiddleName = "Петрович",
                        Gender = TypeGender.М,
                        DateOfBirthday = new DateTime(1983, 8, 7),
                        PlaceOfResidence = "Витебск, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "irina.fedorova",
                        Email = "irina.fedorova@example.com",
                        Surname = "Федорова",
                        Name = "Ирина",
                        MiddleName = "Викторовна",
                        Gender = TypeGender.Ж,
                        DateOfBirthday = new DateTime(1996, 9, 22),
                        PlaceOfResidence = "Гродно, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "mikhail.lukyanov",
                        Email = "mikhail.lukyanov@example.com",
                        Surname = "Лукьянов",
                        Name = "Михаил",
                        MiddleName = "Станиславович",
                        Gender = TypeGender.М,
                        DateOfBirthday = new DateTime(1980, 4, 11),
                        PlaceOfResidence = "Брест, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "ksenia.bakhtina",
                        Email = "ksenia.bakhtina@example.com",
                        Surname = "Бахтина",
                        Name = "Ксения",
                        MiddleName = "Михайловна",
                        Gender = TypeGender.Ж,
                        DateOfBirthday = new DateTime(1997, 12, 4),
                        PlaceOfResidence = "Могилев, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "roman.pozniak",
                        Email = "roman.pozniak@example.com",
                        Surname = "Позняк",
                        Name = "Роман",
                        MiddleName = "Вячеславович",
                        Gender = TypeGender.М,
                        DateOfBirthday = new DateTime(1991, 2, 10),
                        PlaceOfResidence = "Минск, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "nina.martynova",
                        Email = "nina.martynova@example.com",
                        Surname = "Мартынова",
                        Name = "Нина",
                        MiddleName = "Ивановна",
                        Gender = TypeGender.Ж,
                        DateOfBirthday = new DateTime(1989, 5, 28),
                        PlaceOfResidence = "Гомель, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "alexandra.dobrovolskaya",
                        Email = "alexandra.dobrovolskaya@example.com",
                        Surname = "Добровольская",
                        Name = "Александра",
                        MiddleName = "Геннадиевна",
                        Gender = TypeGender.Ж,
                        DateOfBirthday = new DateTime(1994, 7, 9),
                        PlaceOfResidence = "Гродно, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "sergey.rudenko",
                        Email = "sergey.rudenko@example.com",
                        Surname = "Руденко",
                        Name = "Сергей",
                        MiddleName = "Дмитриевич",
                        Gender = TypeGender.М,
                        DateOfBirthday = new DateTime(1981, 11, 12),
                        PlaceOfResidence = "Брест, Беларусь",
                        EmailConfirmed = true
                    },
                    new User
                    {
                        UserName = "tatyana.tikhomirova",
                        Email = "tatyana.tikhomirova@example.com",
                        Surname = "Тихомирова",
                        Name = "Татьяна",
                        MiddleName = "Петровна",
                        Gender = TypeGender.Ж,
                        DateOfBirthday = new DateTime(1992, 3, 16),
                        PlaceOfResidence = "Минск, Беларусь",
                        EmailConfirmed = true
                    }
                };

                _context.Users.AddRange(users);
                _context.SaveChanges();
            }

            //Добавляем кабинеты
            if (!_context.Office.Any())
            {
                var office = new List<Office>
                {
                        new Office
                        {
                            Name = "Кабинет 1",
                            Number = 101,
                            Floor = 1
                        },
                        new Office
                        {
                            Name = "Кабинет 2",
                            Number = 102,
                            Floor = 1
                        },

                        // Кабинеты для Стоматологии на Свердлова (Гомель)
                        new Office
                        {
                            Name = "Кабинет 3",
                            Number = 101,
                            Floor = 1
                        },
                        new Office
                        {
                            Name = "Кабинет 4",
                            Number = 102,
                            Floor = 1
                        },

                        // Кабинеты для Стоматологии на Ленина (Минск)
                        new Office
                        {
                            Name = "Кабинет 5",
                            Number = 101,
                            Floor = 1
                        },
                        new Office
                        {
                            Name = "Кабинет 6",
                            Number = 102,
                            Floor = 1
                        }
                };
                _context.Office.AddRange();
                _context.SaveChanges();
            }


            //Добавляем специальности
            if (!_context.Specialization.Any())
            {
                var specialization = new List<Specialization>
                {
                        new Specialization { Name = "Терапевт" },
                        new Specialization { Name = "Хирург" },
                        new Specialization { Name = "Ортодонт" },
                        new Specialization { Name = "Пародонтолог" },
                        new Specialization { Name = "Имплантолог" },
                        new Specialization { Name = "Детский стоматолог" },
                        new Specialization { Name = "Стоматолог-хирург" }
                };
                _context.Specialization.AddRange();
                _context.SaveChanges();
            }

            //Добавляем работников
            if (!_context.Workers.Any())
            {
                var workers = new List<Workers>
                {
                    new Workers
                    {
                        InsuranceNumber = "INS123456789",
                        LaborNumber = "LAB123456",
                        Education = "Медицинское образование, стоматология",
                        DateOfEmployment = new DateTime(2020, 5, 10),
                        StomatologyId = _context.Stomatology.FirstOrDefault(s => s.Name == "Стоматология на Мира")?.Id,
                        UserId = _context.Users.FirstOrDefault(u => u.UserName == "alexey.morozov")?.Id.ToString()  // Связь с пользователем "ivan.petrov"
                    },
                    new Workers
                    {
                        InsuranceNumber = "INS987654321",
                        LaborNumber = "LAB654321",
                        Education = "Медицинское образование, ортопедическая стоматология",
                        DateOfEmployment = new DateTime(2019, 3, 25),
                        StomatologyId = _context.Stomatology.FirstOrDefault(s => s.Name == "Стоматология на Свердлова")?.Id,
                        UserId = _context.Users.FirstOrDefault(u => u.UserName == "elena.kuzmina")?.Id.ToString()  // Связь с пользователем "olga.kovaleva"
                    },
                    new Workers
                    {
                        InsuranceNumber = "INS123456789",
                        LaborNumber = "LAB123456",
                        Education = "Медицинское образование, стоматология",
                        DateOfEmployment = new DateTime(2020, 5, 10),
                        StomatologyId = _context.Stomatology.FirstOrDefault(s => s.Name == "Стоматология на Ленина")?.Id,
                        UserId = _context.Users.FirstOrDefault(u => u.UserName == "pavel.mikhaylov")?.Id.ToString()  // Связь с пользователем "ivan.petrov"
                    },
                    new Workers
                    {
                        InsuranceNumber = "INS987654321",
                        LaborNumber = "LAB654321",
                        Education = "Медицинское образование, ортопедическая стоматология",
                        DateOfEmployment = new DateTime(2019, 3, 25),
                        StomatologyId = _context.Stomatology.FirstOrDefault(s => s.Name == "Стоматология на Ленина")?.Id,
                        UserId = _context.Users.FirstOrDefault(u => u.UserName == "daria.karpova")?.Id.ToString()  // Связь с пользователем "olga.kovaleva"
                    },
                    new Workers
                    {
                        InsuranceNumber = "INS123456789",
                        LaborNumber = "LAB123456",
                        Education = "Медицинское образование, стоматология",
                        DateOfEmployment = new DateTime(2020, 5, 10),
                        StomatologyId = _context.Stomatology.FirstOrDefault(s => s.Name == "Стоматология на Мира")?.Id,
                        UserId = _context.Users.FirstOrDefault(u => u.UserName == "vladimir.korolev")?.Id.ToString()  // Связь с пользователем "ivan.petrov"
                    },
                    new Workers
                    {
                        InsuranceNumber = "INS987654321",
                        LaborNumber = "LAB654321",
                        Education = "Медицинское образование, ортопедическая стоматология",
                        DateOfEmployment = new DateTime(2019, 3, 25),
                        StomatologyId = _context.Stomatology.FirstOrDefault(s => s.Name == "Стоматология на Мира")?.Id,
                        UserId = _context.Users.FirstOrDefault(u => u.UserName == "irina.fedorova")?.Id.ToString()  // Связь с пользователем "olga.kovaleva"
                    }
                };

                _context.Workers.AddRange(workers);
                _context.SaveChanges();
            }

            // Добавление докторов
            if (!_context.Doctor.Any())
            {
                var doctors = new List<Doctor>
                {
                    new Doctor
                    {
                        SpecializationId = _context.Specialization.FirstOrDefault(s => s.Name == "Терапевт")?.Id,
                        OfficeId = _context.Office.FirstOrDefault(o => o.Name == "Кабинет 6")?.Id,
                        WorkersId = _context.Workers.FirstOrDefault(w => w.UserId == _context.Users.FirstOrDefault(u => u.UserName == "alexey.morozov").Id.ToString())?.Id
                    },
                    new Doctor
                    {
                        SpecializationId = _context.Specialization.FirstOrDefault(s => s.Name == "Ортопед")?.Id,
                        OfficeId = _context.Office.FirstOrDefault(o => o.Name == "Кабинет 5")?.Id,
                        WorkersId = _context.Workers.FirstOrDefault(w => w.UserId == _context.Users.FirstOrDefault(u => u.UserName == "elena.kuzmina").Id.ToString())?.Id
                    },
                    new Doctor
                    {
                        SpecializationId = _context.Specialization.FirstOrDefault(s => s.Name == "Терапевт")?.Id,
                        OfficeId = _context.Office.FirstOrDefault(o => o.Name == "Кабинет 4")?.Id,
                        WorkersId = _context.Workers.FirstOrDefault(w => w.UserId == _context.Users.FirstOrDefault(u => u.UserName == "pavel.mikhaylov").Id.ToString())?.Id
                    },
                    new Doctor
                    {
                        SpecializationId = _context.Specialization.FirstOrDefault(s => s.Name == "Ортопед")?.Id,
                        OfficeId = _context.Office.FirstOrDefault(o => o.Name == "Кабинет 3")?.Id,
                        WorkersId = _context.Workers.FirstOrDefault(w => w.UserId == _context.Users.FirstOrDefault(u => u.UserName == "daria.karpova").Id.ToString())?.Id
                    },
                    new Doctor
                    {
                        SpecializationId = _context.Specialization.FirstOrDefault(s => s.Name == "Терапевт")?.Id,
                        OfficeId = _context.Office.FirstOrDefault(o => o.Name == "Кабинет 2")?.Id,
                        WorkersId = _context.Workers.FirstOrDefault(w => w.UserId == _context.Users.FirstOrDefault(u => u.UserName == "vladimir.korolev").Id.ToString())?.Id
                    },
                    new Doctor
                    {
                        SpecializationId = _context.Specialization.FirstOrDefault(s => s.Name == "Ортопед")?.Id,
                        OfficeId = _context.Office.FirstOrDefault(o => o.Name == "Кабинет 1")?.Id,
                        WorkersId = _context.Workers.FirstOrDefault(w => w.UserId == _context.Users.FirstOrDefault(u => u.UserName == "irina.fedorova").Id.ToString())?.Id
                    }
                };

                _context.Doctor.AddRange(doctors);
                _context.SaveChanges();
            }

            // Добавление пациентов
            if (!_context.Patient.Any())
            {
                var patients = new List<Patient>
                {
                    new Patient
                    {
                        PlaceOfWork = "ООО \"МедТех\"",
                        UserId = _context.Users.FirstOrDefault(u => u.UserName == "alexandr.ivanov")?.Id.ToString()
                    },
                    new Patient
                    {
                        PlaceOfWork = "ЗАО \"Здоровье\"",
                        UserId = _context.Users.FirstOrDefault(u => u.UserName == "natalia.smirnova")?.Id.ToString()
                    },
                    new Patient
                    {
                        PlaceOfWork = "ЗАО \"Здоровье\"",
                        UserId = _context.Users.FirstOrDefault(u => u.UserName == "sergey.popov")?.Id.ToString()
                    },
                    new Patient
                    {
                        PlaceOfWork = "ЗАО \"Здоровье\"",
                        UserId = _context.Users.FirstOrDefault(u => u.UserName == "anna.sokolova")?.Id.ToString()
                    },
                    new Patient
                    {
                        PlaceOfWork = "ЗАО \"Здоровье\"",
                        UserId = _context.Users.FirstOrDefault(u => u.UserName == "dmitry.belov")?.Id.ToString()
                    },
                    new Patient
                    {
                        PlaceOfWork = "ЗАО \"Здоровье\"",
                        UserId = _context.Users.FirstOrDefault(u => u.UserName == "evgeny.karpov")?.Id.ToString()
                    },
                    new Patient
                    {
                        PlaceOfWork = "ЗАО \"Здоровье\"",
                        UserId = _context.Users.FirstOrDefault(u => u.UserName == "tatiana.ivanova")?.Id.ToString()
                    }
                };

                _context.Patient.AddRange(patients);
                _context.SaveChanges();
            }

            //Добавление РабочегоВремени
            if (!_context.WorkingHours.Any())
            {
                var workingHours = new List<WorkingHours>
                {
                        // Понедельник
                        new WorkingHours { DayOfTheWeek = 1, Start = new TimeSpan(8, 0, 0), End = new TimeSpan(9, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 1, Start = new TimeSpan(9, 0, 0), End = new TimeSpan(10, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 1, Start = new TimeSpan(10, 0, 0), End = new TimeSpan(11, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 1, Start = new TimeSpan(11, 0, 0), End = new TimeSpan(12, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 1, Start = new TimeSpan(12, 0, 0), End = new TimeSpan(13, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 1, Start = new TimeSpan(13, 0, 0), End = new TimeSpan(14, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 1, Start = new TimeSpan(14, 0, 0), End = new TimeSpan(15, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 1, Start = new TimeSpan(15, 0, 0), End = new TimeSpan(16, 0, 0) },

                        // Вторник
                        new WorkingHours { DayOfTheWeek = 2, Start = new TimeSpan(8, 0, 0), End = new TimeSpan(9, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 2, Start = new TimeSpan(9, 0, 0), End = new TimeSpan(10, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 2, Start = new TimeSpan(10, 0, 0), End = new TimeSpan(11, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 2, Start = new TimeSpan(11, 0, 0), End = new TimeSpan(12, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 2, Start = new TimeSpan(12, 0, 0), End = new TimeSpan(13, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 2, Start = new TimeSpan(13, 0, 0), End = new TimeSpan(14, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 2, Start = new TimeSpan(14, 0, 0), End = new TimeSpan(15, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 2, Start = new TimeSpan(15, 0, 0), End = new TimeSpan(16, 0, 0) },

                        // Среда
                        new WorkingHours { DayOfTheWeek = 3, Start = new TimeSpan(8, 0, 0), End = new TimeSpan(9, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 3, Start = new TimeSpan(9, 0, 0), End = new TimeSpan(10, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 3, Start = new TimeSpan(10, 0, 0), End = new TimeSpan(11, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 3, Start = new TimeSpan(11, 0, 0), End = new TimeSpan(12, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 3, Start = new TimeSpan(12, 0, 0), End = new TimeSpan(13, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 3, Start = new TimeSpan(13, 0, 0), End = new TimeSpan(14, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 3, Start = new TimeSpan(14, 0, 0), End = new TimeSpan(15, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 3, Start = new TimeSpan(15, 0, 0), End = new TimeSpan(16, 0, 0) },

                        // Четверг
                        new WorkingHours { DayOfTheWeek = 4, Start = new TimeSpan(8, 0, 0), End = new TimeSpan(9, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 4, Start = new TimeSpan(9, 0, 0), End = new TimeSpan(10, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 4, Start = new TimeSpan(10, 0, 0), End = new TimeSpan(11, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 4, Start = new TimeSpan(11, 0, 0), End = new TimeSpan(12, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 4, Start = new TimeSpan(12, 0, 0), End = new TimeSpan(13, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 4, Start = new TimeSpan(13, 0, 0), End = new TimeSpan(14, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 4, Start = new TimeSpan(14, 0, 0), End = new TimeSpan(15, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 4, Start = new TimeSpan(15, 0, 0), End = new TimeSpan(16, 0, 0) },

                        // Пятница
                        new WorkingHours { DayOfTheWeek = 5, Start = new TimeSpan(8, 0, 0), End = new TimeSpan(9, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 5, Start = new TimeSpan(9, 0, 0), End = new TimeSpan(10, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 5, Start = new TimeSpan(10, 0, 0), End = new TimeSpan(11, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 5, Start = new TimeSpan(11, 0, 0), End = new TimeSpan(12, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 5, Start = new TimeSpan(12, 0, 0), End = new TimeSpan(13, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 5, Start = new TimeSpan(13, 0, 0), End = new TimeSpan(14, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 5, Start = new TimeSpan(14, 0, 0), End = new TimeSpan(15, 0, 0) },
                        new WorkingHours { DayOfTheWeek = 5, Start = new TimeSpan(15, 0, 0), End = new TimeSpan(16, 0, 0) }
                };

                _context.WorkingHours.AddRange(workingHours);
                _context.SaveChanges();
            }
            //Добавление РабочегоВремени/Доктора
            if (!_context.WorkingHouseDoctor.Any())
            {
                var workingHouseDoctors = new List<WorkingHouseDoctor>
                {
                    new WorkingHouseDoctor
                    {
                        DoctorId = _context.Doctor
                        .Where(d => d.Workers.User.Email == "alexey.morozov")
                        .Select(d => d.Id)
                        .FirstOrDefault(),
                        WorkingHouseId = 1 // ID рабочего времени (понедельник, 9-10)
                    },
                    new WorkingHouseDoctor
                    {
                         DoctorId = _context.Doctor
                        .Where(d => d.Workers.User.Email == "alexey.morozov")
                        .Select(d => d.Id)
                        .FirstOrDefault(),
                        WorkingHouseId = 2 // ID рабочего времени (понедельник, 9-10)
                    },
                    new WorkingHouseDoctor
                    {
                         DoctorId = _context.Doctor
                        .Where(d => d.Workers.User.Email == "alexey.morozov")
                        .Select(d => d.Id)
                        .FirstOrDefault(),
                        WorkingHouseId = 3 // ID рабочего времени (вторник, 8-9)
                    },
                    new WorkingHouseDoctor
                    {
                         DoctorId = _context.Doctor
                        .Where(d => d.Workers.User.Email == "alexey.morozov")
                        .Select(d => d.Id)
                        .FirstOrDefault(),
                        WorkingHouseId = 4 // ID рабочего времени (вторник, 9-10)
                    },
                    new WorkingHouseDoctor
                    {
                         DoctorId = _context.Doctor
                        .Where(d => d.Workers.User.Email == "alexey.morozov")
                        .Select(d => d.Id)
                        .FirstOrDefault(),
                        WorkingHouseId = 5 // ID рабочего времени (среда, 8-9)
                    },
                    new WorkingHouseDoctor
                    {
                         DoctorId = _context.Doctor
                        .Where(d => d.Workers.User.Email == "alexey.morozov")
                        .Select(d => d.Id)
                        .FirstOrDefault(),
                        WorkingHouseId = 6 // ID рабочего времени (среда, 9-10)
                    }
                };

                _context.WorkingHouseDoctor.AddRange(workingHouseDoctors);
                _context.SaveChanges();
            }
        }
    }
}

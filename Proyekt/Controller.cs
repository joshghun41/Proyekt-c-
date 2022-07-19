using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyekt
{
    public class Controller
    {
        static Worker worker1 = new Worker
        {
            Name = "Cosqun",
            Surname = "Gulmemmedli",
            City = "Baku",
            Age = 18,
            Phone = "0513133323",
            Email = "gcosqun@gmail.com",
            Password = "cosqun123",
            cv = new List<Cv>
            {
                new Cv
                {
                    Qualification="Programmer",
                    School="220 School",
                    Uniscore=310,
                    Skills=new List<string>{"Turkish Language","c# programin language","Python programin Language"},
                    companies=new List<Companies>
                    {
                    new Companies
                    {
                        Name="Pasha Holding",
                        Position="Programmer",
                        Start=new DateTime(2019,05,01),
                        Finish=new DateTime(2022,05,01),
                    }
                    }


                }
            }


        };
        static Worker worker2 = new Worker
        {
            Name = "Murad ",
            Surname = "Gulmemmedli",
            City = "Baku",
            Age = 17,
            Phone = "0556359500",
            Email = "muradglm@gmail.com",
            Password = "murad123",
            cv = new List<Cv>
            {
                new Cv
                {
                    Qualification="Dizayner",
                    School="220 School",
                    Uniscore=350,
                    Skills=new List<string>{"Turkish Language","3D Max","Corona"},
                    companies=new List<Companies>
                    {
                    new Companies
                    {
                        Name="Zeferoglu Insaat",
                        Position="Dizayner",
                        Start=new DateTime(2020,06,02),
                        Finish=new DateTime(2022,07,01),
                    }
                    }


                }
            }


        };

        static Vacancies vacancie1 = new Vacancies
        {

            Name = "Programist Freelancer",
            CompanyName = "Google",
            Requirments = new List<string> { "Is saati yxodur Bug lari fix etmek ucun zaman verilir", "Yas heddi 20-50 arasi ", "Online Isliye tapsiriglari Komanda seklinde ede biler", "GitHub ile IS tecrubesi olan", "HTMl,CSS,JavaScript bilen" },
            Salary = 2500

        };

        static Vacancies vacancie2 = new Vacancies
        {
            Name = "Dizayner Freelancer",
            CompanyName = "Pasha Holding",
            Requirments = new List<string> { "Is saati yoxdur Tapsiriglari yerine yetirme vaxdi verilir", "Yas heddi 20-50 arasi ", "Online Isliye tapsiriglari Komanda seklinde ede bilen", "3DMAx da 2 illik tecrube olmalidir", "Tikilis standartlarin bilen ", "Dizayn etme bacarigi olmalidir", "3DMAx,AutoCad bilenmelidir" },
            Salary = 2000

        };

        static Vacancies vacancie3 = new Vacancies
        {
            Name = "Dizayner ",
            CompanyName = "Pasha Holding",
            Requirments = new List<string> { "Is saati 08:00 dan 18:00 a kimi", "Yas heddi 20-50 arasi ", "Inglis dili vacibdir", "3DMAx da 2 illik tecrube olmalidir", "Tikilis standartlarin bilen ", "Dizayn etme bacarigi olmalidir", "3DMAx,AutoCad bilenmelidir" },
            Salary = 2800

        };
        static Employer employer1 = new Employer
        {
            Name = "Sadiq",
            Surname = "Sadixov",
            City = "Baku",
            Age = 30,
            Phone = "0515554656",
            Email = "sadiq@gmail.com",
            Password = "sadiq123",
            Vacancie = new List<Vacancies> { vacancie1, vacancie2 }
        };

        static Employer employer2 = new Employer
        {
            Name = "Aynur",
            Surname = "SMedetova",
            City = "Baku",
            Age = 29,
            Phone = "0506664669",
            Email = "aynur@gmail.com",
            Password = "aynur123",
            Vacancie = new List<Vacancies> { vacancie3 }
        };

        static List<Human> humans = new List<Human> { employer1, employer2, worker1, worker2 };









        public static void Start()
        {


            Console.Clear();
            Console.Write("Email : ");
            string email = Console.ReadLine();

            Console.Write("Password : ");
            string password = Console.ReadLine();

            Human human = new Human();
            foreach (var item in humans)
            {
                if (item.Email == email && item.Password == password)
                {
                    human = item;
                    break;
                }
            }
            if (human is Employer)
            {
                Employer employer = (Employer)human;
                Console.WriteLine($@"
Vakansiyalara bax    [1]
Vakansiya Elave et   [2]
Bildirislere bax     [3]
");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    employer.ShowAll();

                }
                else if (secim == "2")
                {
                    employer.AddVacancies();
                }
                else if (secim == "3")
                {

                }

            }
            else if (human is Worker)
            {
                Worker worker = (Worker)human;
                Console.Write($@"
Vakansiyalara bax         [1]
Vakansiyara muraciet et   [2]
CV-elave et               [3]
Cv-ye bax                 [4]

");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    foreach (var item in humans)
                    {
                        if (item is Employer)
                        {
                            Employer employer = (Employer)item;
                            employer.ShowAll();
                        }
                    }
                }
                else if (secim == "2")
                {
                    foreach (var item in humans)
                    {
                        if (item is Employer)
                        {
                            Employer employer = (Employer)item;
                            employer.ShowAll();
                        }
                    }
                    Console.WriteLine($@"Muraciet etmek isdediyiniz Vakansiyanin ID-sini daxil edin");

                }
                else if (secim == "3")
                {
                    worker.AddCv();

                }
                else if (secim == "4")
                {
                    foreach (var item in worker.cv) { item.Show();} 
                }
            }



        }
    }
}

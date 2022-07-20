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
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("--- ---  ---  ---  www.BOSS.az --- --- --- ----");
                Console.ResetColor();
                Console.WriteLine($@"
                      
                                            Giris Etmek [1]
                                            Qeydiyyat   [2]
");
                string secim2 = Console.ReadLine();
                if (secim2 == "1")   //
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

                        } //showall
                        else if (secim == "2")
                        {
                            employer.AddVacancies();

                        }//vakansiya elave etemk
                        else if (secim == "3")
                        {
                            foreach (var item in employer.Vacancie)
                            {
                                item.show();
                                foreach (var item1 in item.Notification)
                                {
                                    Console.WriteLine($"Worker Id : {item1.ApplicantİD}");
                                    item1.show();
                                }

                            }
                            Console.WriteLine("Hansi ID muracieti qebul edeceksiniz ?");
                            int secim5= Convert.ToInt32(Console.ReadLine());

                            foreach (var item in humans)
                            {
                                if (secim5 ==item.Id)
                                {
                                    Worker worker =  (Worker)(item);
                                    Console.WriteLine( item.Id ); 
                                    Console.WriteLine($@"
Qebul etmek ucun [1]
Redd etmek ucun  [2]
");
                                    int secim6= Convert.ToInt32(Console.ReadLine());
                                    if (secim6==1)
                                    {
                                        worker.notification = "Qebul edildi.";

                                    }
                                    else if (secim6 == 2)
                                    {
                                        worker.notification = "Qebul edilmedifdgfgd.";
                                    }

                                }
                            }
                          
                        }

                    }
                    //--------------------------------------------------------
                    else if (human is Worker)
                    {
                        Worker worker = (Worker)human;
                        Console.Write($@"
Vakansiyalara bax         [1]
Vakansiyara muraciet et   [2]
CV-elave et               [3]
Cv-ye bax                 [4]
Bildirislere bax          [5]

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
                            } //show all
                            Console.WriteLine($@"Muraciet etmek isdediyiniz Vakansiyanin ID-sini daxil edin");
                            int select4 = Convert.ToInt32(Console.ReadLine());
                            foreach (var item in humans)
                            {
                                if (item is Employer)
                                {
                                    Employer employer = (Employer)item;
                                    foreach (var emp in employer.Vacancie)
                                    {
                                        if (emp.Id == select4)
                                        {
                                            Notification notification = new Notification
                                            {
                                                ApplicantCV = worker.cv,
                                                ApplicantName = worker.Name,
                                                NotificationDate = DateTime.Now,
                                                ApplicantİD=worker.Id

                                            };
                                            emp.Notification.Add(notification);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        else if (secim == "3")
                        {
                            worker.AddCv();

                        }
                        else if (secim == "4")
                        {
                            foreach (var item in worker.cv) { item.Show(); }
                        }
                        else if(secim == "5")
                        {
                            Console.WriteLine(worker.notification); 
                        }
                    }

                }
                //----------------------------------------------------------------------------------
                else if (secim2 == "2")
                {
                    #region Qeydiyyat



                    Console.Write("Adinizi daxil edin : ");
                    string name = Console.ReadLine();

                    Console.Write("Soyad i daxil edin : ");
                    string surname = Console.ReadLine();

                    Console.Write("Yasadiginiz seheri qeyd edin: ");
                    string city = Console.ReadLine();

                    Console.Write("Telefon nomresini qeyd edin :  +994");
                    string phone = Console.ReadLine();

                    Console.Write("Yasinizi daxil edin: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Console.Write("MAil qeyd edin :");
                    string mail = Console.ReadLine();
                    Console.Write("sirrenizi qeyd edin :");
                    string newpassword = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Sifreni yeniden qeyd edin: ");
                    string newpasswordcopy = Console.ReadLine();
                    if (newpassword == newpasswordcopy)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($@"
            Isveren ucun [1]
            Isci usun    [2]    : ");
                        string secim3 = Console.ReadLine();
                        if (secim3 == "1") //Employer
                        {
                            Employer employer = new Employer
                            {
                                Name = name,
                                Surname = surname,
                                City = city,
                                Phone = phone,
                                Age = age,
                                Email = mail,
                                Password = newpassword,

                            };
                            humans.Add(employer);

                        }
                        else if (secim3 == "2") //Worker
                        {
                            Worker worker = new Worker
                            {
                                Name = name,
                                Surname = surname,
                                City = city,
                                Phone = phone,
                                Age = age,
                                Email = mail,
                                Password = newpassword,

                            };
                            humans.Add(worker);

                        }

                        Console.WriteLine("                           Qeydiyyat ugurla tamamlandi....");
                    }
                    #endregion
                }  //qeydiyyat



            }
        }
    }
}

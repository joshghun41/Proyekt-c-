using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyekt
{
    public class Employer:Human
    {
        public List<Vacancies> Vacancie { get; set; }

        public void ShowAll()
        {
            foreach (Vacancies vacancies in Vacancie)
            {
                vacancies.show();
            }
        }


        public void AddVacancies()
        {
            Vacancies newVacancy = new Vacancies();

            Console.Write("Company Name : ");
            newVacancy.CompanyName = Console.ReadLine();

            Console.Write("Position Name : ");
            newVacancy.Name = Console.ReadLine();

            Console.Write("Salary per month : ");
            newVacancy.Salary = double.Parse(Console.ReadLine());

            Console.Write("Enter Count of Requirments : ");
            int requirmentCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < requirmentCount; i++)
            {
                Console.Write($"[{i + 1}]");
                newVacancy.Requirments[i] = Console.ReadLine();
            }

            Vacancie.Add(newVacancy);
        }
    }
}

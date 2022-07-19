using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyekt
{
    public class Worker : Human
    {
        public List<Cv> cv { get; set; }

        public void showcv()
        {

            foreach (var item in cv)
            {
                Console.WriteLine(item);
            };



        }
        public Companies GetCompany()
        {
            Companies companies = new Companies();
            Console.Write("Company Name : ");
            companies.Name = Console.ReadLine();

            Console.Write("Position Name : ");
            companies.Position = Console.ReadLine();

            Console.Write(" time to start: ");
            companies.Start = DateTime.Parse(Console.ReadLine());

            Console.Write("time to finish : ");
            companies.Finish = DateTime.Parse(Console.ReadLine());
            return companies;
        }
            public void AddCv()
        {
            Cv cv1 = new Cv();

            Console.Write("Company Name : ");
            cv1.Qualification = Console.ReadLine();

            Console.Write("Position Name : ");
            cv1.School = Console.ReadLine();

            Console.Write("Salary per month : ");
            cv1.Uniscore = double.Parse(Console.ReadLine());

            Console.Write("Enter Count of CV : ");
            int CVCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < CVCount; i++)
            {
                Console.Write($"[{i + 1}]");
                cv1.Skills[i] = Console.ReadLine();

            }

            int Companiescount = int.Parse(Console.ReadLine());
            for (int i = 0; i < Companiescount; i++)
            {
                Console.Write($"[{i + 1}]");
                cv1.companies[i] = GetCompany();

            }



        }

    }
}

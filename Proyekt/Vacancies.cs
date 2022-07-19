using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyekt
{
    public class Vacancies
    {
        public int Id { get; set; }
        public static int StaticId { get; set; }
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public List<string> Requirments { get; set; }
        public double Salary { get; set; }
        public Vacancies()
        {
            Id = ++StaticId;
        }

        public void show()
        {
            Console.WriteLine($@"
--------------------------------------------
Vakaniyanin Id-si : {Id}
Kompanyanin adi :   {CompanyName}
Vakasnsiya adi :    {Name}
Maas :              {Salary}
Requirments:    
"
);
            foreach (var item in Requirments)
            {
                Console.WriteLine(item);
            };


        }

      
    }
}

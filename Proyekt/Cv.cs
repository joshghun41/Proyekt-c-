using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyekt
{
    public class Cv
    {
        public string Qualification { get; set; }
        public string School { get; set; }
        public double Uniscore { get; set; }
        public List<string> Skills { get; set; }
        public List<Companies> companies { get; set; }

        public void Show()
        {
            Console.WriteLine($@"---------------------------
Ixtisas :   {Qualification}
School  :   {School}
UniScore :  {Uniscore}
Skills:
");
            foreach (string skill in Skills)
            {
                Console.WriteLine(skill);
            }
            Console.WriteLine("Companies");
            foreach (Companies companies in companies)
            {
                Console.WriteLine(companies);
                companies.Show();
            }
            
        }

        
    }
}

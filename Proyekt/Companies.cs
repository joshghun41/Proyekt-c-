using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyekt
{
    public class Companies
    {
        public string Name { get; set; }


        public string Position { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        public void Show()
        {
            Console.WriteLine($@"-------
            Campanyanin adi : {Name}
            Pazisyasi :       {Position}
            Baslama vaxdi:    {Start}
            Bitme vaxdi :     {Finish}
            
            
            ");
        }
      
    }
}

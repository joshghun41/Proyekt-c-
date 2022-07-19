using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyekt
{
    public  class Notification
    {
        public int Id { get; set; }
        public static int StaticID { get; set; }
        public int ApplicantİD { get; set; }
        public string ApplicantName { get; set; }
        public List<Cv> ApplicantCV { get; set; }
        public DateTime NotificationDate { get; set; }

        public void  Notifications()
        {
            Id = ++StaticID;
        }
    }
}

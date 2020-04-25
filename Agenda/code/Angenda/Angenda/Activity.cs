using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angenda
{
    class Activity
    {
        private string name { get; set; }
        private string description { get; set; }
        private ActivityDate time { get; set; }
        List<Person> participants; 

        public Activity()
        {
            List<Person> participants = new List<Person>();
        }

        public override string ToString()
        {
            return name + ' ' + description + ' ' + time.ToString() + ' ' + participants;
        }
    }
}

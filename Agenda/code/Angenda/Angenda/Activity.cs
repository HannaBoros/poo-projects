using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angenda
{
    class Activity
    {
        public string ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public ActivityDate time { get; set; }
        public List<Person> participants; 

        public Activity()
        {
            List<Person> participants = new List<Person>();
        }

        public override string ToString()
        {
            return name + ' ' + description;
        }
    }
}

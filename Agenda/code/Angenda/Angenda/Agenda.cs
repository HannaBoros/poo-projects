using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angenda
{
    class Agenda
    {
        public string Id { get; set; }
        public string name { get; set; }
        public Person person { get; set; }
        public List<Activity> activities { get; set; }



        public Agenda()
        {

        }

        private string getActivities()
        {
            string activities = "";
            foreach(Activity a in this.activities)
            {
                activities += a.ToString() + "/n";
            }
            return activities;
        }

        public override string ToString()
        {
            return name + ' ' + person.ToString() + ' ' + getActivities();
        }
    }
}

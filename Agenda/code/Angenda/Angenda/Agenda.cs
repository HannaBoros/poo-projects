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
            activities = new List<Activity>();
        }

        public void addActivity(Activity activity)
        {
            this.activities.Add(activity);
        }

        private string getActivities()
        {
            string allact = "";
            foreach(Activity a in this.activities)
            {
                allact += a.ToString() + ";";
            }
            return allact;
        }

        public override string ToString()
        {
            //return name + ' ' + person.ToString() + ' ' + getActivities();
            return name + person.ToString() +'\n' + getActivities();
        }
    }
}

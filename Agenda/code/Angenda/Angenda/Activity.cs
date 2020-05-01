using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angenda
{
    class Activity
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public ActivityDate time { get; set; }
        public List<Person> participants { get; }

        public Activity()
        {
            this.participants = new List<Person>();
        }
        public Activity(int ID, string name, string description, ActivityDate time)
        {
            this.ID = ID;
            this.name = name;
            this.description = description;
            this.time = time;
            this.participants = new List<Person>();
        }

        public void AddParticipants(Person person)
        {
            this.participants.Add(person);
        }

        private string getParticipants()
        {
            string allParticipants = "";
            foreach (Person p in this.participants)
            {
                allParticipants += p.ToString() + ";";
            }
            return allParticipants;
        }
        public override string ToString()
        {
            return name + "; " + description + "; Duration: " + time.ToString()+";\n Participants: "+getParticipants();
        }
    }
}

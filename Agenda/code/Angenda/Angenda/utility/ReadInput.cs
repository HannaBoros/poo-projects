using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using Angenda;
using System.Globalization;

namespace Angenda.utility
{
    class ReadInput
    {
        public string path;
        private List<Person> persons;
        private List<Activity> activities;
        public List<Agenda> agendas { get; private set; }
        public ReadInput(string path)
        {
            this.persons = new List<Person>();
            this.activities = new List<Activity>();
            this.agendas = new List<Agenda>();
            this.path = path;
            this.read_persons();
            this.read_activities();
        }
        public void read_persons()
        {
            //https://stackoverflow.com/questions/3507498/reading-csv-files-using-c-sharp
            string file_persons = @"C:\Users\Hanniel\Desktop\university\programare orientata pe obiecte\proiecte\poo-projects\Agenda\input\persons.csv";
            using (TextFieldParser parser = new TextFieldParser(file_persons))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    Person p = new Person();
                    p.ID = int.Parse(fields[0]);
                    p.lastName = fields[1];
                    p.firstName = fields[2];
                    p.emailAddress = fields[3];
                    p.phoneNumber = fields[4];
                    p.birthDay = fields[5];
                    persons.Add(p);
                }
            }
        }

        public List<Person> createParticipants(string[] fields)
        {
            List<Person> participants = new List<Person>();
            for (int i = 5; i < fields.Length; i++)
            {
                int personID = int.Parse(fields[i]);
                Person p = persons.Find(person => person.ID == personID);
                if(p!=null)
                {
                    participants.Add(p);
                }
                
            }
            return participants;
        }
        public static Activity create_activity(string[] fields, List<Person> persons)
        {
            Activity a = new Activity();
            a.ID = int.Parse(fields[0]);
            a.name = fields[1];
            a.description = fields[2];
            ActivityDate ad = new ActivityDate();
            CultureInfo provider = new CultureInfo("fr-FR");
            ad.startDate = DateTime.ParseExact(fields[3], "g", provider);
            ad.finishDate = DateTime.ParseExact(fields[4], "g", provider);
            a.time = ad;    
            for (int i = 5; i < fields.Length; i++)
            {  
                int personID = int.Parse(fields[i]);
                Person p = persons.Find(person => person.ID == personID); 
                if (p != null)
                {
                    
                    a.AddParticipants(p);
                }

            }
            return a;

        }
        public void read_activities()
        {
            //https://stackoverflow.com/questions/3507498/reading-csv-files-using-c-sharp
            string activityPerson = @"C:\Users\Hanniel\Desktop\university\programare orientata pe obiecte\proiecte\poo-projects\Agenda\input\activities.csv";
            using (TextFieldParser parser = new TextFieldParser(activityPerson))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                   
                    Activity a = create_activity(fields, this.persons);
                    this.activities.Add(a);
                }
            }
        }

        public List<Agenda> read_agendas()
        {
            using (TextFieldParser parser = new TextFieldParser(this.path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    Agenda agenda = new Agenda();
                    agenda.Id = int.Parse(fields[0]);
                    agenda.name = fields[1];
                    int personID = int.Parse(fields[2]);
                    Person p = this.persons.Find(person => person.ID == personID);
                    agenda.person = p;
                    for(int i = 3; i < fields.Length; i++)
                    {
                        int activityID = int.Parse(fields[i]);
                        Activity currentActivity = activities.Find(activity => activity.ID == activityID);
                        if (currentActivity != null)
                        {
                            agenda.addActivity(currentActivity);
                        }
                    }

                    agendas.Add(agenda);
                }
                return this.agendas;
            }
        }
    }
}

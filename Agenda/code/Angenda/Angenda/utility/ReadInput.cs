using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using Angenda;

namespace Angenda.utility
{
    class ReadInput
    {


        public static List<Person> read_csv(string path)
        {
            //https://stackoverflow.com/questions/3507498/reading-csv-files-using-c-sharp

            List<Person> persons = new List<Person>();
            using (TextFieldParser parser = new TextFieldParser(path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    Person p = new Person();
                    p.ID = fields[0];
                    p.lastName = fields[1];
                    p.firstName = fields[2];
                    p.emailAddress = fields[3];
                    p.phoneNumber = fields[4];
                    p.birthDay = fields[5];
                    persons.Add(p);
                }
            }
            return persons;
        }

        private static Activity create_activity(string[] fields)
        {
            Activity p = new Activity();
            p.ID = fields[0];
            p.name = fields[1];
            p.description = fields[2];
            // p.time = fields[3];
            // p.participants = fields[4];
            return p;

        }
        public static List<Activity> read_csvActivities(string path)
        {
            //https://stackoverflow.com/questions/3507498/reading-csv-files-using-c-sharp

            List<Activity> activities = new List<Activity>();
            using (TextFieldParser parser = new TextFieldParser(path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    Activity a = create_activity(fields);
                   
                    activities.Add(a);
                }
            }
            return activities;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Angenda.utility;

namespace Angenda
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<Person> persons = ReadInput.read_csv(@"C:\Users\Hanniel\Desktop\programare orientata pe obiecte\proiecte\poo-projects\Agenda\input\persons.csv");
            Display.DisplayList(persons);
            List<Activity> activities = ReadInput.read_activities(@"C:\Users\Hanniel\Desktop\programare orientata pe obiecte\proiecte\poo-projects\Agenda\input\activities.csv");
            Display.DisplayList(activities);*/

            string path = @"C:\Users\Hanniel\Desktop\university\programare orientata pe obiecte\proiecte\poo-projects\Agenda\input\agendas.csv";
            ReadInput ri = new ReadInput(path);
            List<Agenda> agendaList = ri.read_agendas();
           

            //create a new person
            Person newPerson = new Person();
            newPerson.lastName = "Perfect";
            newPerson.firstName = "Legolas";
            newPerson.ID = 3;
            newPerson.phoneNumber = "07899765";
            newPerson.birthDay = "23/03/1810";
            Console.WriteLine(newPerson);
            Console.WriteLine();

            //crearea unei Agende si adaugarea la lista de Agende
            Agenda newAgenda = new Agenda(3,"Agenda 3", newPerson);
            agendaList.Add(newAgenda);
            

            //crearea unei activitati si adaugarea in agenda unei persoane
            string[] v = new string[] { "117", "pescuit", "la cris", "15/06/2008 08:30", "15/06/2008 12:30"};
            Activity newActivity = ReadInput.create_activity(v, new List<Person>());
            newActivity.AddParticipants(newPerson);
            newAgenda.addActivity(newActivity);
            Display.DisplayList(agendaList);




        }
    }
}

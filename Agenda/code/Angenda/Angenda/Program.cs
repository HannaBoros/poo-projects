using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Angenda.utility;

namespace Angenda
{
    class Program
    {
        public static void DeleteAFromAgenda(string agendaName, string activityName, List<Agenda> listag)
        {
            Agenda a = listag.Find(agenda => agenda.name == agendaName);
            a.DeleteActivity(activityName);
        }

        public static List<Activity> ActivitiesFound(int idPerson, DateTime start, DateTime finish, List<Agenda> agendas)
        {
            Agenda a = agendas.Find(agenda => agenda.person.ID == idPerson);
           return  a.FindActivitiesByTime(start, finish);
            
        }
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

            //cautarea unei activitati
            Activity search=newAgenda.SearchActivityByName("pescuit");
            if(search==null)
                Console.WriteLine("ACtivity was not found in the agenda");
            else
                Console.WriteLine(search);

            //stergerea unei activitati
            DeleteAFromAgenda("Agenda 1", "workout", agendaList);

            //stergerea unei agende
            agendaList.Remove(newAgenda);

            //generarea unui raport cu toate activitatile unei persoane dintr-un anumit interval de timp
            //new DateTime("15/06/2008 12:30"),n 
            Console.WriteLine();
            CultureInfo provider = new CultureInfo("fr-FR");
            DateTime startDate = DateTime.ParseExact("15/06/2008 08:30", "g", provider);
            DateTime finishDate = DateTime.ParseExact("15/06/2008 12:30", "g", provider);
           List<Activity> list= ActivitiesFound(1, startDate, finishDate, agendaList);
            Display.DisplayList(list);



        }
    }
}

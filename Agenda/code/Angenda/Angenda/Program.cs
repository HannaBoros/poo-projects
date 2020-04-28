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
            Display.DisplayList(agendaList);

        }
    }
}

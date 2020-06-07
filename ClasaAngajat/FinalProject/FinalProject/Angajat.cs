using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FinalProject
{
    public class Angajat: IEquatable<Angajat>, IComparable<Angajat>
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime time { get; set; }

        public override string ToString()
        {

            return lastName + ' ' + firstName + "=>" + " time of hiring:" + ' ' + time + " => vechime: " + getVechime() + " days";

        }

        private string getVechime()
        {
            return DateTime.Now.Subtract(this.time).ToString("%d");
        }

        public bool Equals(Angajat other)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Angajat s)
        {
            StringComparer comparer = StringComparer.Create(new CultureInfo("ro-RO"), true);

            int orderLastName = comparer.Compare(lastName, s.lastName);
            if (orderLastName != 0)
                return orderLastName;


            int orderFirstName = comparer.Compare(firstName, s.firstName);
            if (orderFirstName != 0)
                return orderFirstName;

            return 0;
        }
    }
}

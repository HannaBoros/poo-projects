using System;
using System.Globalization;
using System.Linq;

namespace Clasa_elevi
{
    class Student : IEquatable<Student>, IComparable<Student>
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public double average { get; set; }
        public Student()
        {

        }

        public override string ToString()
        {

            return lastName + ' ' + firstName + "=>"+ " Average:" + ' '+ average;

        }

        public bool Equals(Student other)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Student s)
        {
            if (this.average < s.average) return 1;
            if (this.average > s.average) return -1;

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

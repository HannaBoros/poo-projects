using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angenda
{
    class Person
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string phoneNumber { get; set; }
        private string emailAddress { get; set; }
        private string birthDay { get; set; }

        public Person()
        {

        }

        public override string ToString()
        {
           return  firstName+ ' '+lastName+' '+ ";"+' '+phoneNumber+' '+ ";" + ' '+emailAddress + ' ' + ";" + ' ' + birthDay + ' ';
        }


    }
}

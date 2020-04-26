using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angenda
{
    class Person
    {
        public string ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string emailAddress { get; set; }
        public string birthDay { get; set; }

        public Person()
        {

        }

        public override string ToString()
        {
           return ID + ":" + ' ' + firstName + ' '+lastName+ ";"+' '+phoneNumber+ ";"+' '+emailAddress+ ";" + ' ' + birthDay + ';';
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angenda
{
    class Agendaa
    {
        private string name { get; set; }
        private Person person { get; set; }
        private Activity activity { get; set; }



        public Agendaa()
        {

        }


        public override string ToString()
        {
            return name + ' ' + person + ' ' + activity;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angenda
{
    class ActivityDate
    {
        
        public DateTime startDate { get; set; }
        public DateTime finishDate { get; set; }

        public ActivityDate()
        {

        }

        public override string ToString()
        {
            return startDate.ToString()  + "--" + finishDate.ToString();
        }
    }
}

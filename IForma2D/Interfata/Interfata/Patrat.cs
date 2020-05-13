using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfata
{
    class Patrat : IForma2D
    {
        public float L; //lungime latura
        public string Denumire { get; }

        public Patrat(float L, string Denumire)
        {
            this.L = L;
            this.Denumire = Denumire;

         }

        public float Arie()
        {
          
            return L * L;
        }

        public float LungimeaFrontierei()
        {
          
            return 4 * L;
        }
    }
}

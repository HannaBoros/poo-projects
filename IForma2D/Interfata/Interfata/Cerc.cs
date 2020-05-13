using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfata
{
    class Cerc : IForma2D
    {
        public float R; //raza

        public string Denumire { get; }
        public Cerc(float R, string Denumire)
        {
            this.R = R;
            this.Denumire = Denumire;
        }
        public float Arie()
        {
           
            return (float)Math.PI * R * R;
        }

        public float LungimeaFrontierei()
        {
            
            return (float)Math.PI * 2 * R;
        }
    }
}

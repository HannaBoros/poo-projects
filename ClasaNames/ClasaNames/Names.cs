using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasaNames
{
    public class Names
    {

        public List<string> names;
        public int dimensiune;
        public bool error;
        public Names(int dimensiune)
        {
            this.names = new List<string>();

            this.dimensiune = dimensiune;
            for (int i = 0; i < dimensiune; i++)
            {
                this.names.Insert(i, "empty");
            }
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < dimensiune)
                {
                    error = false;
                    return names.ElementAt(index);
                }
                else
                {
                    error = true;
                    throw new ArgumentException("Index out of range");

                    
                }
            }
            set
            {
                if (index >= 0 && index < dimensiune)
                {
                    names.Insert(index, value);
                    error = false;
                }
                else
                {
                    error = true;
                    throw new ArgumentException("Index out of range");

                }
            }
        }
        public string this[string indexer]
        {
            get
            {
                int index;
                try
                { index = int.Parse(indexer); }
                catch (FormatException)
                {
                    throw new ArgumentException("string index not valid integer");
                }
                if (index >= 0 && index < dimensiune)
                {
                    error = false;
                    return names.ElementAt(index);
                }
                else
                {
                    error = true;
                    throw new ArgumentException("Index out of range");

                   
                }
            }

        }
        public override string ToString()
        {
            string r = "";
           for(int i = 0; i<this.dimensiune;i++)
           {
                r += i+ ":" + this[i]+"\n";
           }
            return r;

        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Lista<T>
    {
        public List<T> list;
        public Lista()
        { this.list = new List<T>(); }
      
        public void Add(T element)
        {
            list.Add(element);
        }
        public void Remove(T element)
        {
            list.Remove(element);
        }
        public void Sort(Comparison<T> comparison)
        {
            if(comparison != null) 
                list.Sort(comparison);
            else
                list.Sort();
        }
        public int Count()
        {
            return list.Count();
        }
        public override string ToString()
        {
            string s = "";
            foreach(T t in list)
            {
                s += t.ToString() + "\n";
               
            }
            return s;

        }
        public List<string> getLines()
        {
            List<string> lines = new List<string>();
            foreach (T t in list)
            {
                lines.Add(t.ToString());
            }

            return lines;
        }


    }
}

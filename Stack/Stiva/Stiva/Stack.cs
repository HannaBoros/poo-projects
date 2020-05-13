using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stiva
{
    public class GenericStack<T>
    {
        public List<T> stack ;
        public int size { get; }
        public GenericStack(int size)
        {
            this.stack = new List<T>();
            this.size = size;
        }

        private int top()
        {
            return this.stack.Count() - 1;
        }
        public void Push(T elem)
        {
            if (top()<this.size-1)
            {
                stack.Add(elem);
            }
            else
            {
                throw new ArgumentException("Stack is Full");
            }
        }
        private bool IsEmpty()
        {
            return top()+1 == 0;
        }
        public T Pop()
        {
           if(!IsEmpty())
           {
                T t = stack.ElementAt(top());
                stack.RemoveAt(top());
                return t;
           }
           else
           {
                throw new ArgumentException("Stack is Empty");
           }
        }
        public void Clear()
        {
            stack.Clear();
        }

        
        public override string ToString()
        {
           
            StringBuilder sb = new StringBuilder("");
            for (int i = stack.Count()-1; i >=0; i--)
            {
                sb.Append(stack.ElementAt(i) + "\n");
            }
           return sb.ToString();
            
        }
    }

}

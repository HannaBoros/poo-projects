using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stiva
{

   

    class Program
    {
        public static void test_push_pop()
        {
            GenericStack<int> stackOfInts = new GenericStack<int>(4);
            stackOfInts.Push(1);
            stackOfInts.Push(2);
            stackOfInts.Push(3);
            Console.WriteLine("Stack:");
            Console.WriteLine(stackOfInts.ToString());
            int nrPop = stackOfInts.Pop();
            Console.WriteLine("Popped Stack");
            Console.WriteLine(stackOfInts.ToString());
            Console.WriteLine($"popped number: {nrPop}");
        }

        public static void test_push_exception()
        {
            GenericStack<int> stackOfInts = new GenericStack<int>(1);
            stackOfInts.Push(1);
            Console.WriteLine(stackOfInts.ToString());

            stackOfInts.Push(2);
            Console.WriteLine(stackOfInts.ToString());

        }

        public static void test_pop_exception()
        {
            GenericStack<int> stackOfInts = new GenericStack<int>(2);
            int nr=  stackOfInts.Pop();
            Console.WriteLine(stackOfInts.ToString());
        }

        public static void test_clear()
        {
            GenericStack<string> stackOfStrings = new GenericStack<string>(4);
            stackOfStrings.Push("licenta");
            stackOfStrings.Push("master");
            stackOfStrings.Push("doctorat");
            Console.WriteLine("Stack of strings");
            Console.WriteLine(stackOfStrings.ToString());
            stackOfStrings.Clear();
            Console.WriteLine("Cleared Stack");
            Console.WriteLine(stackOfStrings.ToString());



        }
        static void Main(string[] args)
        {
            test_push_pop();
            Console.WriteLine();
            //Console.WriteLine("Testing push argument exeption");
            //test_push_exception();
            // Console.WriteLine("Testing push argument exeption");
            // test_pop_exception();
            test_clear();


        }
    }
}

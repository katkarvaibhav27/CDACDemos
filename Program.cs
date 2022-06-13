using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncActionPredicate
{
    class Program
    {
        static void Main()
        {
            Action o1 = Display;
            o1();

            Action<string> o2 = Display;
            o2("hello");

            Action<string, int> o3 = Display;
            o3("a", 1);

            Func<int, int, int> o4 = Add;

            //int result = o4(10, 20);

            Console.WriteLine(o4(10,20));

            Func<string, int, string> o5 = DoSomething;
            Console.WriteLine(o5("Vikram",4));

            Func<int, bool> o6 = IsEven;
            Console.WriteLine(o6(10));

            Predicate<int> o7 = IsEven;
            Console.WriteLine(o7(10));

            Console.ReadLine();
        }
        static void Display()
        {
            Console.WriteLine("display");
        }
        static void Display(string s)
        {
            Console.WriteLine("display" + s);
        }
        static void Display(string s,int i)
        {
            Console.WriteLine("display" + s + i.ToString());
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static string DoSomething(string  a, int b)
        {
            return a.Substring(b);
        }

        static bool IsEven(int a)
        {
            return a % 2 == 0;
        }
    }
}

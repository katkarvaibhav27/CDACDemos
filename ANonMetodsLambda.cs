using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonMethodsAndLambdas
{
    class Program
    {
        static void Main1()
        {
            //Display();
            int a = 10;
            //anon methods
            Action o = delegate()
            {
                Console.WriteLine(++a);
                Console.WriteLine("anon method");
            };
            o();

            Console.WriteLine(a);
            Func<int, int, int> o1 = delegate(int x, int y)
            {
                return x+y;
            };
            Console.ReadLine();
        }

        //lambdas
        static void Main()
        {
            Func<int, int> o1 = GetDouble;
            Console.WriteLine(o1(10));

            Func<int, int> o2 = delegate(int x)
            {
                return x * 2;
            };
            Console.WriteLine(o2(10));


            Func<int, int> o3 = a => a * 2;
            //Func<int, int> o3 = (a) => a * 2;
            Console.WriteLine(o3(10));

            Func<int, int, int> o4 = (a, b) => a + b;
            Console.WriteLine(o4(10,20));

            Predicate<int> o6 = a => a % 2 == 0;
            Console.WriteLine(o6(10));

            Predicate<Employee> o7 = emp => emp.Basic > 10000;
            Console.WriteLine(  o7(new Employee {Basic = 5000 }) );

            Console.ReadLine();
        }
        static int GetDouble(int x)
        {
            return x * 2;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static bool IsEven(int a)
        {
            //if (a % 2 == 0)
            //    return true;
            //else
            //    return false;
            return a % 2 == 0;
        }
        //static bool IsBasicMoreThan10000(Employee e)
        //{
           
        //    //return a % 2 == 0;
        //}
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic{ get; set; }


    }
}

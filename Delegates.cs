using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // Object
    // Delegate
    // MultiCastDelegate
    // Del1

    //step 1 : create the delegate class having the same signature as the func to call
    public delegate void Del1();

    public delegate int DelAdd(int a, int b);
    class Program
    {
        static void Main1()
        {
            //step 2 : create the delegate object passing func name as parameter
            Del1 objdel = new Del1(Display);
            //step 3 : call the func indirectly with the delegate object
            objdel();
            Console.ReadLine();
        }
        static void Main2()
        {
            Del1 objdel = Display;
            objdel();
            Console.ReadLine();
        }
        static void Mai3n()
        {
            Del1 objdel = Display;
            objdel();

            objdel = Show;
            objdel();

            Console.ReadLine();
        }
        static void Main4()
        {
            Del1 objdel = Display;
            objdel();

            Console.WriteLine();
            objdel += Show;
            objdel();

            Console.WriteLine();
            objdel += Display;
            objdel();

            Console.WriteLine();
            objdel -= Display;
            objdel();


            Console.ReadLine();
        }

        static void Main5()
        {
            Del1 objdel = Display;
            objdel();

            Console.WriteLine();
            objdel =(Del1) Delegate.Combine(objdel, new Del1(Show));
            objdel();

            Console.WriteLine();
            objdel = (Del1)Delegate.Combine(objdel, new Del1(Display));
            objdel();


            Console.WriteLine();
            //objdel = (Del1)Delegate.Remove(objdel, new Del1(Display));
            objdel = (Del1)Delegate.RemoveAll(objdel, new Del1(Display));
            objdel();
 
            Console.ReadLine();
        }
        static void Main6()
        {
            //DelAdd objdel = new DelAdd(Add);
            DelAdd objdel = Add;

            Console.WriteLine( objdel(10,20)  );

            //todo - use multicast delegates with functions that have a return value
        }
        static void Main7()
        {
            Del1 o1 = Class1.Display;
            o1();
            Class1 obj = new Class1();

            o1 = obj.Show;
            o1();
            Console.ReadLine();
        }
        static void Display()
        {
            Console.WriteLine("disp");
        }
        static void Show()
        {
            Console.WriteLine("Show");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }

    public class Class1
    {
        public static void Display()
        {
            Console.WriteLine("disp");
        }
        public void Show()
        {
            Console.WriteLine("Show");
        }
    }
}

namespace UsingDelegatesAsAParameterToAFunction  //allows us to decide which func to call at run time (late binding)
{
    //public delegate int DelAdd(int a = 0, int b = 0);
    public delegate int DelAdd(int a , int b );
    public class Program
    {
        static void Main()
        {
            Console.WriteLine(CallMathOperation(Add, 20, 10));
            Console.WriteLine(CallMathOperation(Subtract, 3, 2));
            Console.WriteLine(CallMathOperation(Multiply, 10, 3));
            Console.WriteLine(CallMathOperation(Divide, 9, 3));
            Console.ReadLine();
        }
        static int CallMathOperation(DelAdd objDelAdd, int i, int j)
        {
            //return objDelAdd();  //if you use default values/optional parameters
            return objDelAdd(i, j);
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static int Divide(int a, int b)
        {
            return a / b;
        }

    }
}

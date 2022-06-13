using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandling
{
    class Program
    {
        //static void Main()
        //{
        //    Class1 objClass1 = new Class1();

        //    //pass the function as a parameter to the delegate object
        //    objClass1.InvalidP1 += objClass1_InvalidP1;
        //    objClass1.P1 = 200;

        //    Console.ReadLine();
        //}
        //static void objClass1_InvalidP1()
        //{
        //    Console.WriteLine("event handler called");
        //}
        static void Main2()
        {
            Class1 objClass1 = new Class1();

            //one event, multiple handlers
            objClass1.InvalidP1 += ObjClass1_InvalidP1;
            objClass1.InvalidP1 += Handler2;

            objClass1.P1 = 200;

            Console.ReadLine();
        }
        static void Main3()
        {
            Class1 objClass1 = new Class1();
            Class1 obj2 = new Class1();

            //multiple events, same handler

            objClass1.InvalidP1 += ObjClass1_InvalidP1;
            obj2.InvalidP1 += ObjClass1_InvalidP1;

            objClass1.P1 = 200;
            obj2.P1 = 200;

            Console.ReadLine();
        }
        static void Main6()
        {
            Class1 objClass1 = new Class1();

            //dynamic event handling - adding or removing handlers at runtime
            objClass1.InvalidP1 += ObjClass1_InvalidP1;
            objClass1.InvalidP1 += Handler2;

            objClass1.P1 = 200;


            Console.WriteLine();
            objClass1.InvalidP1 -= ObjClass1_InvalidP1;
            objClass1.InvalidP1 -= Handler2;
            objClass1.P1 = 200;


            Console.ReadLine();
        }
        private static void ObjClass1_InvalidP1()
        {
            Console.WriteLine("event handler called");
        }
        private static void Handler2()
        {
            Console.WriteLine("event handler2 called");
        }
    }

    //developer
    //step 1 : create a delegate class having the same signature as the event handler
    public delegate void InvalidP1EventHandler();
    public class Class1
    {
        //Step 2 : declare an event ( event is a delegate object)
        public event InvalidP1EventHandler InvalidP1;

        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    //step 3: call the event whenever needed (make a call to delegate object)
                    if (InvalidP1 != null)  //if no handlers are present then Exception is thrown. Check for null to avoid exception
                        InvalidP1();
                }
            }
        }
    }

}
//parameters in events
namespace EventHandling2
{
    class Program
    {
        static void Main()
        {
            Class1 objClass1 = new Class1();
            objClass1.InvalidP1 += ObjClass1_InvalidP1;

            objClass1.P1 = 200;
            Console.ReadLine();
        }

        private static void ObjClass1_InvalidP1(int InvalidValue)
        {
            Console.WriteLine("Invalid Value passed was " + InvalidValue);
        }
    }

    //developer
    //step 1 : create a delegate class having the same signature as the event handler
    public delegate void InvalidP1EventHandler(int InvalidValue);


    public class Class1
    {
        //Step 2 : declare an event ( event is a delegate object)
        //public event Action InvalidP1;
        //public event Action<int> InvalidP1;

        public event InvalidP1EventHandler InvalidP1;

        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    //step 3: call the event whenever needed (make a call to delegate object)
                    if (InvalidP1 != null)  //if no handlers are present then Exception is thrown. Check for null to avoid exception
                        InvalidP1(value);
                }
            }
        }
    }

}


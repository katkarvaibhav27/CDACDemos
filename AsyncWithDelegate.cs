using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


//call a func async. func has no params and void return value
namespace AsyncCodeWithDelegates1
{
    class Program
    {
        static void Main1()
        {
            Console.WriteLine("before");

            Action oDel = Display;
            oDel.BeginInvoke(null, null);  //runs Display on a separate thread

            Console.WriteLine("after");
            Console.ReadLine();

        }
        static void Display()
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("display");
        }
    }
}


//call a func async. func has param and void return value
namespace AsyncCodeWithDelegates2
{
    class Program
    {
        static void Main2()
        {
            Console.WriteLine("before");

            Action<string> oDel = Display;
            oDel.BeginInvoke("abc",null, null);  //runs Display on a separate thread

            Console.WriteLine("after");
            Console.ReadLine();

        }
        static void Display(string s)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("display" + s);
        }
    }
}

//call a func async. func has param and return value. also using a callback func (AsyncCallBack)
namespace AsyncCodeWithDelegates3
{
    class Program
    {
        static void Main3()
        {
            Console.WriteLine("before");

            Func<string,string> oDel = Display;
            IAsyncResult ar = oDel.BeginInvoke("abc", MyCallBackFunc, null);  //runs Display on a separate thread
            Console.WriteLine("after");
            Console.ReadLine();

        }
        static string Display(string s)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("display" + s);
            return s.ToUpper();
        }
        static void MyCallBackFunc(IAsyncResult ar)
        {
            Console.WriteLine("callback fn called");
        }
    }
}


//call a func async. func has param and return value. also using a callback func (AsyncCallBack)
//oDel is global 
namespace AsyncCodeWithDelegates4
{
    class Program
    {
       static Func<string, string> oDel = Display;
       static void Main4()
        {
            Console.WriteLine("before");

            IAsyncResult ar = oDel.BeginInvoke("abc", MyCallBackFunc, null);  //runs Display on a separate thread
            
            Console.WriteLine("after");
            Console.ReadLine();
        }
        static string Display(string s)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("display" + s);
            return s.ToUpper();
        }
        static void MyCallBackFunc(IAsyncResult ar)
        {
            Console.WriteLine("callback fn called");
            string retval = oDel.EndInvoke(ar);
            Console.WriteLine(retval);
        }
    }
}

//call a func async. func has param and return value. also using a callback func (AsyncCallBack)
//pass oDel in BeginInvoke. Receive it in callback func as ar.AsyncState
namespace AsyncCodeWithDelegates5
{
    class Program
    {
        static void Main5()
        {
            Console.WriteLine("before");

            Func<string, string> oDel = Display;
            //IAsyncResult ar = oDel.BeginInvoke("abc", MyCallBackFunc, "extra passed string");  //runs Display on a separate thread
            IAsyncResult ar = oDel.BeginInvoke("abc", MyCallBackFunc, oDel);  //runs Display on a separate thread
            Console.WriteLine("after");
            Console.ReadLine();

        }
        static string Display(string s)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("display" + s);
            return s.ToUpper();
        }
        static void MyCallBackFunc(IAsyncResult ar)
        {
            Console.WriteLine("callback fn called");
            //string extra_value = ar.AsyncState.ToString();
            //Console.WriteLine(extra_value);


            Func<string, string> oDel = (Func<string, string>)ar.AsyncState;
            string retval = oDel.EndInvoke(ar);

            Console.WriteLine(retval);

        }
    }
}

//call a func async. func has param and return value. also using a callback func (AsyncCallBack)
//use anonymous method to access oDel from Main func
namespace AsyncCodeWithDelegates6
{
    class Program
    {
        static void Main6()
        {
            Console.WriteLine("before");

            Func<string, string> oDel = Display;
            IAsyncResult ar2 = oDel.BeginInvoke("abc", delegate(IAsyncResult ar)
            {
                Console.WriteLine("callback fn called");

                string retval = oDel.EndInvoke(ar);
                Console.WriteLine(retval);

            }, null);  //runs Display on a separate thread
            Console.WriteLine("after");
            Console.ReadLine();

        }
        static string Display(string s)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("display" + s);
            return s.ToUpper();
        }
        
    }
}


//call a func async. func has param and return value. also using a callback func (AsyncCallBack)
// use AsyncResult.AsyncDelegate to get a reference of the delegate object used in oDel.EndInvoke(..)
namespace AsyncCodeWithDelegates7
{
    class Program
    {
        static void Main7()
        {
            Console.WriteLine("before");

            Func<string, string> oDel = Display;
            IAsyncResult ar = oDel.BeginInvoke("abc", MyCallBackFunc, null);  //runs Display on a separate thread
            Console.WriteLine("after");
            Console.ReadLine();

        }
        static string Display(string s)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("display" + s);
            return s.ToUpper();
        }
        static void MyCallBackFunc(IAsyncResult ar)
        {
            AsyncResult objAr =(AsyncResult) ar;
            
            Console.WriteLine("callback fn called");

            //string retval = ((Func<string, string>)objAr.AsyncDelegate).EndInvoke(ar);
            //string retval = (objAr.AsyncDelegate as Func<string, string>).EndInvoke(ar);
            Func<string, string> oDel = (Func<string, string>)objAr.AsyncDelegate;
            string retval = oDel.EndInvoke(ar);

            Console.WriteLine(retval);
        }
    }
}

//calling a method asynchronously using delObj.BeginInvoke(....
namespace AsyncCodeWithDelegates8
{
    class Program
    {
        static void Main8()
        {
            Console.WriteLine("Before");
            Action o = Display;
            IAsyncResult ar = o.BeginInvoke(null, null);
            Console.WriteLine("After");

            //while (!ar.IsCompleted) ;
            ar.AsyncWaitHandle.WaitOne();  //waits for the thread to finish execution. Like Thread.Join
            //Console.ReadLine();
        }
        static void Display()
        {
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Display");
        }
    }
}









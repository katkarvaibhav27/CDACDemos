using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class Program
    {
        static void Main()
        {
            IntegerStack o = new IntegerStack(3);
            o.Push(10);
            o.Push(20);
            o.Push(30);

            Console.WriteLine(o.Pop());
            Console.WriteLine(o.Pop());
            Console.WriteLine(o.Pop());

            MyStack<int> o1 = new MyStack<int>(3);
            o1.Push(10);
            o1.Push(20);
            o1.Push(30);

            Console.WriteLine(o1.Pop());
            Console.WriteLine(o1.Pop());
            Console.WriteLine(o1.Pop());


            MyStack<string> o2 = new MyStack<string>(3);
            o2.Push("10");
            o2.Push("20");
            o2.Push("30");

            Console.WriteLine(o2.Pop());
            Console.WriteLine(o2.Pop());
            Console.WriteLine(o2.Pop());


            Console.ReadLine();
        }

        static void NullableExample()
        {
            int? i = 10;
            Nullable<int> i2 = 10;
            //Nullable<string> i3 = "a"; //wont work

        }
        //static void Main1()
        //{
        //    MyStack<int> o = new MyStack<int>(3);

        //    o.Push(10);
        //    o.Push(20);
        //    o.Push(30);

        //    Console.WriteLine(o.Pop());
        //    Console.WriteLine(o.Pop());
        //    Console.WriteLine(o.Pop());

        //    Console.ReadLine();
        //}
        //static void Main()
        //{
        //    MyStack<string> o = new MyStack<string>(3);

        //    o.Push("10");
        //    o.Push("20");
        //    o.Push("30");

        //    Console.WriteLine(o.Pop());
        //    Console.WriteLine(o.Pop());
        //    Console.WriteLine(o.Pop());

        //    Console.ReadLine();
        //}
    }

    class IntegerStack
    {
        int[] arr;
        public IntegerStack(int Size)
        {
            arr = new int[Size];
        }
        int Pos = -1;
        public void Push(int i)
        {
            if (Pos == (arr.Length - 1))
                throw new Exception("Stack full");
            arr[++Pos] = i;
        }
        public int Pop()
        {
            if (Pos == -1)
                throw new Exception("Stack Empty");
            return arr[Pos--];
        }
    }
    class StringStack
    {
        string[] arr;
        public StringStack(int Size)
        {
            arr = new string[Size];
        }
        int Pos = -1;
        public void Push(string i)
        {
            if (Pos == (arr.Length - 1))
                throw new Exception("Stack full");
            arr[++Pos] = i;
        }
        public string Pop()
        {
            if (Pos == -1)
                throw new Exception("Stack Empty");
            return arr[Pos--];
        }
    }


    //where T : class  - T must be a reference type
    //where T : struct - T must be a value type
    //where T : ClassName - T must be either ClassName or a derived class
    //where T : InterfaceName - T must be a class that implements InterfaceName
    //where T : new() - T must have a no parameter constructor

    //constraints can be combined. new() must appear at the end if new() is used
    //where T : ClassName, InterfaceName
    //where T : ClassName, InterfaceName, new()
    class MyStack<T>

    {
        T[] arr;
        public MyStack(int Size)
        {
            //T obj = new T();

            arr = new T[Size];
        }
        int Pos = -1;
        public void Push(T i)
        {
            if (Pos == (arr.Length - 1))
                throw new Exception("Stack full");
            arr[++Pos] = i;
        }
        public T Pop()
        {
            if (Pos == -1)
                throw new Exception("Stack Empty");
            return arr[Pos--];
        }
    }

}
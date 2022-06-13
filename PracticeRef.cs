namespace PracticeRef  // passing ref types
{
    class Program
    {
		public class Class1
		{
			public int i;
		}
	
        static void Main()
        {
            Class1 o = new Class1();
            o.i = 100;
			
            //DoSomething1(o);
			
            //DoSomething2(o);
			
            DoSomething3(ref o);
			
            Console.WriteLine(o.i);
			
            Console.ReadLine();
        }
		
        static void DoSomething1(Class1 obj)  //obj =o;
        {
            //changes made in func (changing value of properties) is reflected in calling code o
            obj.i = 200;
        }
		
        static void DoSomething2(Class1 obj)
        {
            //changes made in func (obj pointing to some other block) is NOT reflected in calling code o

            obj = new Class1();
            obj.i = 200;
        }
		
        static void DoSomething3(ref Class1 obj)
        {
            //changes made in func (obj pointing to some other block) is reflected in calling code o
            obj = new Class1();
            obj.i = 200;
        }
    }

    public class Class1
    {
        public int i;
    }
}

// 200

// 100

// 200
using System;

namespace ReferenceAndValueTypes
{
    class Program
    {
		public class RefClass
		{
			public int num;
		}
		
        static void Main1()
        {
            RefClass obj1 = new RefClass();
            RefClass obj2 = new RefClass();
			
            obj1.num = 100;
            obj2.num = 200;
			
            obj1 = obj2;
            obj2.num = 300;
			
            Console.WriteLine(obj1.num);
            Console.WriteLine(obj2.num);
			
            Console.ReadLine();
        }


		// ********* Value Type ***********
		
        static void Main2()
        {
            int obj1, obj2;
			
            obj1 = 100;
            obj2 = 200;
			
            obj1 = obj2;
            obj2 = 300;
			
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            Console.ReadLine();
        }
		
		
		// *************************
        static void Main3()
        {
            string obj1, obj2;
			
            obj1 = "100";
            obj2 = "200";
			
            obj1 = obj2;
            obj2 = "300";
			
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
			
            Console.ReadLine();
        }
		
		
		// ********** Data Types *********
		
        static void DataTypes()
        {
			// value types : System.ValueType
			
            byte b1; // 1 byte(8 bits) // System.byte // 0 to 255
			
            sbyte b2; // 1 byte // System.Sbyte // -128 to +127 
			
            char ch; // 2 byte // System.Char // ‘\0’
			
            short sh1; // 2 byte // System.Int16
			
            ushort sh2; // 2 byte // System.UInt16 // 0 to 65535	
			
            int i1; // 4 bute // System.Int32
			
            uint i2;	// 4 byte // System.UInt32
			
            long l1; // 8 byte // System.Int64 // 0L
			
            ulong l2; // 8 byte // System.UInt64
			
            float f; // 4 byte // System.Single // 7 digit precision // 0.0f
			
            double d; // 8 byte // System.Double // 14 – 15 digit Precision // 0.0d
			
            decimal d2;  // 16 byte // System.Decimal // 28-29 digit Precision // 0.0m
			
            bool b; // System.Boolean

            string s;
            object o;
        }
    }
}

// 300
// 300

// 200
// 300

//200
//300







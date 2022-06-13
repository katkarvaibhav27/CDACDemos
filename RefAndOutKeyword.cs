namespace RefAndOutKeyword  // using ref, out, in
{
    public class Program
    {
        static void Main()
        {            
            int num1;
            int num2;
			
            Init(out num1, out num2); //initial value not required
			
            Swap(ref num1,ref num2);
			
			DoSomethingWithIn(num1, num2);
			
            Console.WriteLine(num1);
            Console.WriteLine(num2);
			
            Console.ReadLine();
        }
		
		// changes made in function reflect back in calling code
        static void Init(out int num1, out int num2)
        {
            // the initial value is discarded
            // Console.WriteLine(i);
            num1 = 100;
            num2 = 200;
            //out variables MUST be initialized in the function
        }
		
        static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        
		
		// The in keyword causes arguments to be passed by reference 
		// but ensures the argument is not modified
		
        static void DoSomethingWithIn(in int num1, in int num2)
        {
            num1 = 200; // num1 is readonly (in)
            Console.WriteLine(num1);
        }

    }
}

// 200
// 200

// 100
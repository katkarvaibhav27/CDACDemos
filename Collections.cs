using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsExample
{
    class Program
    {
        static void DoSomething()
        {
            object o;
            o = 10;
            //ref type = value type
            //BOXING

            int j;
            j = (int)o;
            //value type = boxed value from the ref type
            //UNBOXING




        }

        static void Main1()
        {
            ArrayList obj = new ArrayList();
            obj.Add("Vikram");
            obj.Add(10);
            obj.Add(true);
            //obj.AddRange(objArrayList)
            //obj.IndexOf("Vikram")
            //obj.LastIndexOf("Vikram")
            //obj.BinarySearch("Vikram")

            //obj.Capacity = no_of_records
            /*
            foreach record in the table
                obj.Add( column value)
            */
            //obj.TrimToSize()

            //obj.Clear(); //removes(deletes) all the elements
            //bool yesno = obj.Contains("Vikram");
            
            //obj.CopyTo(array)
            //obj.ToArray
            
            //obj.Count
            //obj.Insert  //add at specified index
            //obj.InsertRange

            obj.Remove(10); //remove the object
            obj.RemoveAt(0); //index
            //obj.RemoveRange
            foreach (object item in obj)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
        static void Main2()
        {
            //Hashtable objDictionary = new Hashtable();
            SortedList objDictionary = new SortedList();
            objDictionary.Add(10, "Vikram");
            objDictionary.Add(20, "Harsh");
            objDictionary.Add(30, "Ananya");
            //objDictionary.Add(3, "Shweta"); error

            objDictionary[40] = "Shweta";
            objDictionary[10] = "changed value";

            //bool yesno =objDictionary.Contains(1)

            //objDictionary.ContainsKey
            //objDictionary.ContainsValue
            //object Value = objDictionary.GetByIndex(index)
            //objDictionary.
            
            foreach (DictionaryEntry item in objDictionary)
            {
                Console.Write(item.Key);
                Console.WriteLine(item.Value);

            }

            Console.ReadLine();

        }
        static void Main3()
        {
            Stack obj = new Stack();
            obj.Push(10);
            obj.Push(20);

            Console.WriteLine(obj.Peek());
            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Pop());

            Queue q = new Queue();
            //q.Enqueue
            //q.Dequeue
            //q.Peek
        }

        static void Main4()
        {
            List<int> obj = new List<int>();
            obj.Add(10);

            foreach (int item in obj)
            {
                Console.WriteLine(item);
            }
        }
        static void Main5()
        {
            //Dictionary<int, string> objDictionary = new Dictionary<int, string>();
            SortedList<int, string> objDictionary = new SortedList<int, string>();

            objDictionary.Add(10, "Vikram");
            foreach (KeyValuePair<int,string> item in objDictionary)
            {
                Console.Write(item.Key);
                Console.WriteLine(item.Value);

            }
        }
        static void Main6()
        {
            Stack<int> obj = new Stack<int>();
            obj.Push(10);
            obj.Push(20);

            Console.WriteLine(obj.Peek());
            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Pop());

            Queue<int> q = new Queue<int>();
            //q.Enqueue
            //q.Dequeue
            //q.Peek
        }
        static void Main7()
        {
            List<Employee> objEmps = new List<Employee>();
            objEmps.Add(new Employee { EmpNo = 1, Name = "Vikram" });
            objEmps.Add(new Employee { EmpNo = 2, Name = "Harsh" });
            objEmps.Add(new Employee { EmpNo = 3, Name = "Ananya" });
            objEmps.Add(new Employee { EmpNo = 4, Name = "Shweta" });

            foreach (Employee item in objEmps)
            {
                Console.WriteLine(item.EmpNo);
                Console.WriteLine(item.Name);
            }
        }
        static void Main()
        {
            //List<Employee> objEmps = new List<Employee>();
            SortedList<int,Employee> objEmps = new SortedList<int, Employee>();
            objEmps.Add(1,new Employee { EmpNo = 1, Name = "Vikram" });
            objEmps.Add(2,new Employee { EmpNo = 2, Name = "Harsh" });
            objEmps.Add(3,new Employee { EmpNo = 3, Name = "Ananya" });
            objEmps.Add(4,new Employee { EmpNo = 4, Name = "Shweta" });

            foreach (KeyValuePair<int,Employee> item in objEmps)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value.Name);
            }

        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }

    }
}

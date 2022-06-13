using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionExample
{
    class Program
    {
        static void Main()
        {

            string filename = @"D:\Trainings\CdacPune\Day1\ClassBasics\bin\Debug\ClassBasics.exe";
            //string filename = "D:\\Trainings\\CdacPune\\Day1\\ClassBasics\\bin\\Debug\\ClassBasics.exe";
            Assembly asm = Assembly.LoadFrom(filename);
            //Console.WriteLine(asm.FullName);

            Console.WriteLine(asm.GetName().Name);
            Type[] arrTypes = asm.GetTypes();
            foreach (Type t in arrTypes)
            {
                Console.WriteLine("   " + t.Name);
                MethodInfo[] arrMethods = t.GetMethods();
                foreach (MethodInfo m in arrMethods)
                {
                    Console.WriteLine("      " + m.Name);
                }
            }


            Console.ReadLine();
        }
    }
}

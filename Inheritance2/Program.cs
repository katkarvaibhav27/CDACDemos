using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Manager("Vaibhav", 400000, 10, "Project Manager");
            emp1.DisplayDetails();
            ((IDbFunctions)emp1).Insert();

            GeneralManager emp2 = new GeneralManager("Vaibhav", 650000, 10, "Senior Project Manager", "Company Car");
            emp2.DisplayDetails();
            ((IDbFunctions)emp2).Update();

            CEO emp3 = new CEO("Vaibhav", 1000000, 12);
            emp3.DisplayDetails();
            ((IDbFunctions)emp3).Delete();

            Console.ReadLine();
        }
        public interface IDbFunctions
        {
            void Insert();
            void Update();
            void Delete();
        }
    }
}

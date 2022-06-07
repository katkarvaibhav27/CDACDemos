using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{   
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Vaibhav", 500000, 10);
            //emp1.DisplayDetails();

            Employee emp2 = new Manager("Vaibhav", 500000, 10, "HR");
            //emp2.DisplayDetails();

            Employee emp3 = new GeneralManager("Vaibhav", 500000, 10, "HR", "life insurance");
            //emp3.DisplayDetails();

            CEO emp4 = new CEO("Vaibhav", 500000, 10);
            emp4.DisplayDetails();

            Console.ReadLine();
        }
    }
}

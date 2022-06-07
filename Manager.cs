using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Manager : Employee
    {
        private string designation;
        public string Designation
        {
            set
            {
                if (value != "")
                    this.designation = value;
                else
                    Console.WriteLine("Manager's designation should not be null.");
            }
            get { return designation; }

        }
        public Manager(string Name, decimal Basic, short DeptNo, string Designation)
            : base(Name, Basic, DeptNo)
        {
            this.Designation = Designation;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("------------------ Manager's Details ---------------------------");
            Console.WriteLine("Employee No. : " + this.EmpNo);
            Console.WriteLine("Employee Name : " + this.Name);
            Console.WriteLine("Employee Net Salary : " + this.GetNetSalary());
            Console.WriteLine("Employee Dept No. : " + this.DeptNo);
            Console.WriteLine("Employee Designation : " + this.Designation);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class GeneralManager : Manager
    {
        private string perks;
        public string Perks{ set; get; }
        public GeneralManager(string Name, decimal Basic, short DeptNo, string Designation, string Perks)
            : base(Name, Basic, DeptNo, Designation)
        {
            this.Perks = Perks;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("------------------ General Manager's Details ---------------------------");
            Console.WriteLine("Employee No. : " + this.EmpNo);
            Console.WriteLine("Employee Name : " + this.Name);
            Console.WriteLine("Employee Net Salary : " + this.GetNetSalary());
            Console.WriteLine("Employee Dept No. : " + this.DeptNo);
            Console.WriteLine("Employee Designation : " + this.Designation);
            Console.WriteLine("Employee Perks : " + this.Perks);
        }
    }
}

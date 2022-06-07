using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class CEO : Employee
    {
            public CEO(string Name, decimal Basic, short DeptNo)
                : base(Name, Basic, DeptNo) { }
            public sealed override decimal GetNetSalary()
            {
                decimal DA = (this.Basic * 40) / 100;
                decimal HRA = (this.Basic * 20) / 100;
                decimal BONUS = 50000;
                decimal netSalary = this.Basic + DA + HRA + BONUS;

                return netSalary;
            }
            public override void DisplayDetails()
            {
                Console.WriteLine("------------------ CEO Details ---------------------------");
                Console.WriteLine("Employee No. : " + this.EmpNo);
                Console.WriteLine("Employee Name : " + this.Name);
                Console.WriteLine("Employee Net Salary : " + this.GetNetSalary());
                Console.WriteLine("Employee Dept No. : " + this.DeptNo);
            }
    }
}


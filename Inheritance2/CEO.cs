using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Inheritance2.Program;

namespace Inheritance2
{
    class CEO : Employee, IDbFunctions
    {
        private decimal basic;
        public override decimal Basic
        {
            get { return basic; }
            set
            {
                if (value >= 800000 && value <= 1200000)
                    this.basic = value;
                else
                    Console.WriteLine("CEO's Salary should be within 800000 and 1200000.");
            }
        }
        public CEO(string Name, decimal Basic, short DeptNo)
                : base(Name: Name, DeptNo: DeptNo)
        {
            this.Basic = Basic;
        }
        public sealed override decimal GetNetSalary()
        {
            decimal netSalary = this.Basic + 200000;

            return netSalary;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("------------------ CEO Details ---------------------------");
            Console.WriteLine("CEO Employee No. : " + this.EmpNo);
            Console.WriteLine("CEO's Name : " + this.Name);
            Console.WriteLine("CEO's Net Salary : " + this.GetNetSalary());
            Console.WriteLine("CEO's Dept No. : " + this.DeptNo);
        }
    }
}

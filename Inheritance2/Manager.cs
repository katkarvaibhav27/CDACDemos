using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Inheritance2.Program;

namespace Inheritance2
{
    class Manager : Employee, IDbFunctions
    {
        protected decimal basic;
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

        public override decimal Basic
        {
            get { return basic; }
            set
            {
                if (value >= 400000 && value <= 800000)
                    this.basic = value;
                else
                    Console.WriteLine("Manager's Salary should be within 400000 and 800000.");
            }
        }
        public Manager(string Name, decimal Basic, short DeptNo, string Designation = null)
            : base(Name:Name, DeptNo:DeptNo)
        {
            this.Basic = Basic;
            this.Designation = Designation;
        }

        public override decimal GetNetSalary()
        {
            decimal DA = (this.Basic * 40) / 100;
            decimal HRA = (this.Basic * 20) / 100;
            decimal BONUS = 20000;
            decimal netSalary = this.Basic + DA + HRA + BONUS;

            return netSalary;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("------------------ Manager's Details ---------------------------");
            Console.WriteLine("Manager's Employee No. : " + this.EmpNo);
            Console.WriteLine("Manager's Name : " + this.Name);
            Console.WriteLine("Manager's Net Salary : " + this.GetNetSalary());
            Console.WriteLine("Manager's designation : " + this.Designation);
            Console.WriteLine("Manager's Dept No. : " + this.DeptNo);
        }
    }
}

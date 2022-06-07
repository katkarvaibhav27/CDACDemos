using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Inheritance2.Program;

namespace Inheritance2
{
    internal class GeneralManager : Manager, IDbFunctions
    {
        public string Perks { set; get; }

        public override decimal Basic
        {
            set
            {
                if (value >= 600000 && value <= 1000000)
                    this.basic = value;
                else
                    Console.WriteLine("General Manager's Salary should be within 600000 and 1000000.");
            }
            get { return basic; }
        }
        public GeneralManager(string Name, decimal Basic, short DeptNo, string Designation, string Perks)
            : base(Name: Name, Basic: Basic, DeptNo:DeptNo, Designation:Designation)
        {
            this.Perks = Perks;
        }

        public override decimal GetNetSalary()
        {
            decimal DA = (this.Basic * 40) / 100;
            decimal HRA = (this.Basic * 20) / 100;
            decimal BONUS = 40000;
            decimal netSalary = this.Basic + DA + HRA + BONUS;

            return netSalary;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("------------------ General Manager's Details ---------------------------");
            Console.WriteLine("GM Employee No. : " + this.EmpNo);
            Console.WriteLine("GM Name : " + this.Name);
            Console.WriteLine("GM Net Salary : " + this.GetNetSalary());
            Console.WriteLine("GM Dept No. : " + this.DeptNo);
            Console.WriteLine("GM Designation : " + this.Designation);
            Console.WriteLine("GM Perks : " + this.Perks);
        }
    }
}

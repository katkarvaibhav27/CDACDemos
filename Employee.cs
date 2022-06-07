using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Employee
    {
        private int empNo;
        private string name;
        protected decimal basic;
        private short deptNo;
        private static int id = 0;
        public int EmpNo
        {
            get { return empNo; }
        }
        public string Name
        {
            set
            {
                if (value != "")
                    this.name = value;
                else
                    Console.WriteLine("Employee name should not be null.");
            }
            get { return name; }
        }
        public decimal Basic
        {
            set
            {
                if (value >= 100000 || value <= 600000)
                    this.basic = value;
                else
                    Console.WriteLine("Employee salary should be between 100000 and 600000");
            }
            get { return basic; }
        }
        public short DeptNo
        {
            set
            {
                if (value > 0)
                    this.deptNo = value;
                else
                    Console.WriteLine("Employee's department should be greater than 0.");
            }
            get { return deptNo; }
        }
        public Employee(string Name = "aa", decimal Basic = 100000, short DeptNo = 1)
        {
            id++;
            empNo = id;
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }
        public virtual decimal GetNetSalary()
        {
            decimal DA = (this.Basic * 40) / 100;
            decimal HRA = (this.Basic * 20) / 100;
            decimal netSalary = this.Basic + DA + HRA;

            return netSalary;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("------------------ Employee's Details ---------------------------");
            Console.WriteLine("Employee No. : " + this.EmpNo);
            Console.WriteLine("Employee Name : " + this.Name);
            Console.WriteLine("Employee Net Salary : " + this.GetNetSalary());
            Console.WriteLine("Employee Dept No. : " + this.DeptNo);
        }
    }
}

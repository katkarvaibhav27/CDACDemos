using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Inheritance2.Program;

namespace Inheritance2
{
    abstract class Employee : IDbFunctions
    {
        private int empNo;
        private string name;
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
        public abstract decimal Basic { set; get; } 

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
        public Employee(string Name = "aa", short DeptNo = 1)
        {
            id++;
            empNo = id;
            this.Name = Name;
            this.DeptNo = DeptNo;
        }
        public abstract decimal GetNetSalary();

        public virtual void DisplayDetails()
        {
            Console.WriteLine("------------------ Employee's Details ---------------------------");
            Console.WriteLine("Employee No. : " + this.EmpNo);
            Console.WriteLine("Employee Name : " + this.Name);
            Console.WriteLine("Employee Net Salary : " + this.GetNetSalary());
            Console.WriteLine("Employee Dept No. : " + this.DeptNo);
        }

        public void Insert()
        {
            Console.WriteLine("Employee - IDb.Insert");
        }

        public void Update()
        {
            Console.WriteLine("Employee - IDb.Update");
        }

        public void Delete()
        {
            Console.WriteLine("Employee - IDb.Delete");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    internal class Employee
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        private int salary;

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                    this.salary = 0;
                else if (value > 20000)
                    this.salary = 20000;
                else
                    this.salary = value;
            }
        }

        private int bonus;

        public int Bonus
        {
            get { return bonus; }
            set
            {
                if (value < 0)
                    this.bonus = 0;
                else if (value > 10000)
                    this.bonus = 10000;
                else
                    this.bonus = value;
            }
        }

        public int TotalSalary
        { get { return this.Salary + this.Bonus; } }
    }
}
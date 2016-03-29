using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Manager : Employee
    {
        private int otherBouns;

        public int OtherBouns
        {
            get { return this.otherBouns; }
            set
            {
                if (value < 0)
                    this.otherBouns = 0;
                else
                    this.otherBouns = value;
            }
        }

        public Manager(string id, string name, int baseSalary, int otherBouns)
            : base(id, name, baseSalary)
        {
            this.OtherBouns = otherBouns;
        }

        public Manager(string id, string name, string baseSalary, string otherBouns)
            : this(id, name, int.Parse(baseSalary), int.Parse(otherBouns))
        { }

        public override double BaseSalary
        {
            get
            {
                return base.BaseSalary;
            }
            set
            {
                base.baseSalary = 22000;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("其他獎金：{0}\n", this.OtherBouns);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Engineer : Employee
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

        private int performance;

        public int Performance
        {
            get { return this.performance; }
            set
            {
                if (value < 0)
                    this.performance = 0;
                else
                    this.performance = value;
            }
        }

        public Engineer(string id, string name, int baseSalary, int performance, int otherBouns)
            : base(id, name, baseSalary)
        {
            this.OtherBouns = otherBouns;
            this.Performance = performance;
        }

        public Engineer(string id, string name, string baseSalary, string performance, string otherBouns)
            : this(id, name, int.Parse(baseSalary), int.Parse(performance), int.Parse(otherBouns))
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
            return base.ToString() + string.Format("業績：{0}\n其他獎金：{1}", this.performance, this.otherBouns);
        }
    }
}
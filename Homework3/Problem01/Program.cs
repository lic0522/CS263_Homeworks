using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string newName = string.Empty;
            int sa = 0;
            int bo = 0;
            Employee user = new Employee();
            Console.Write("姓名：");
            newName = Console.ReadLine();
            user.Name = newName;
            user.Salary = sa;
            user.Bonus = bo;

            do
            {
                Console.Write("底薪：");
            } while (!int.TryParse(Console.ReadLine(), out sa));
            do
            {
                Console.Write("獎金：");
            } while (!int.TryParse(Console.ReadLine(), out bo));

            user = new Employee { Salary = sa, Bonus = bo };
            Console.WriteLine("總薪資為：{0}", user.TotalSalary);
        }
    }
}
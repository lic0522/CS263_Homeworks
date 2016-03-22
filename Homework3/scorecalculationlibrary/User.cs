using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreCalculationLibrary
{
    public class User
    {
        public static void user1()
        {
            Student student = new Student();
            string name = string.Empty;
            int chinese = 0;
            int english = 0;
            int math = 0;
            Console.Write("請輸入姓名:");
            name = Console.ReadLine();

            do
            {
                Console.Write("請輸入國文成績:");
            } while (!int.TryParse(Console.ReadLine(), out chinese));

            do
            {
                Console.Write("請輸入英文成績:");
            } while (!int.TryParse(Console.ReadLine(), out english));

            do
            {
                Console.Write("請輸入數學成績:");
            } while (!int.TryParse(Console.ReadLine(), out math));

            student = new Student(name, chinese, english, math);
            Console.WriteLine(student);
        }
    }
}
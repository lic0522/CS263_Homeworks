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
            Student someone =
                new Student
                {
                    name = "阿東",
                    contact = new Contact
                     {
                         email = "ABC000@gmail.com",
                         phone = "22221111"
                     },
                    data = new Information
                    {
                        className = "一年甲班",
                        studentID = "990001",
                        department = "資管"
                    }
                };
            Console.WriteLine("姓名：" + someone.name);
            Console.WriteLine("電話：" + someone.contact.phone);
            Console.WriteLine("E-Mail：" + someone.contact.email);
            Console.WriteLine("班級：" + someone.data.className);
            Console.WriteLine("學號：" + someone.data.studentID);
            Console.WriteLine("科系：" + someone.data.department);
        }
    }
}
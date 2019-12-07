using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanlityTest.Controller;

namespace QuanlityTest
{
    class Program
    {
        private static void GenerateMenu()
        {
            Console.WriteLine("SELECT FUNCTION");
            Console.WriteLine("1. Add new student");
            Console.WriteLine("2. Display students list");
            Console.WriteLine("3. Exit");
            Console.WriteLine("-----------------");
        }

        static void Main(string[] args)
        {
            bool start = true;
            var controller = new StudentController();

            while (start)
            {
                GenerateMenu();
                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        controller.CreateStudent();
                        break;
                    case 2:
                        controller.PrintListStudent();
                        break;
                    case 3:
                        start = false;
                        break;
                }

            }
        }
    }
}

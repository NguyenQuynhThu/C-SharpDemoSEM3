using QuanlityTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlityTest.Controller
{
    class StudentController
    {
        List<Student> students = new List<Student>();

        public void PrintListStudent()
        {
            Console.WriteLine("| {0, -15} | {1, -15} | {2, -15} | {3, -15} |{4, -15} |{5, -15} |{6, -15} |", "ID", "Name", "Birthday", "Email", "Phone", "CreatedAt", "Status");
            foreach (var st in students)
            {
                if (st.IsNewStudent())
                {
                    Console.WriteLine("| {0, -15} | {1, -15} | {2, -15} | {3, -15} |{4, -15} |{5, -15} |{6, -15} |", st.RollNumber, st.FullName, st.Birthday, st.Email, st.Phone, st.CreatedAt, "New");
                } else if (st.IsDeactive())
                {
                    continue;
                } else
                {
                    Console.WriteLine("| {0, -15} | {1, -15} | {2, -15} | {3, -15} |{4, -15} |{5, -15} |{6, -15} |", st.RollNumber, st.FullName, st.Birthday, st.Email, st.Phone, st.CreatedAt, "Active");
                }

            }

        }

        public void CreateStudent()
        {
            Student st1 = new Student();

            Console.WriteLine("Vui long nhap thong tin sinh vien");
            Console.WriteLine("Ma sinh vien:");
            st1.RollNumber = Console.ReadLine();
            Console.WriteLine("Ho ten:");
            st1.FullName = Console.ReadLine();
            Console.WriteLine("Ngay sinh:");
            st1.Birthday = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Email:");
            st1.Email = Console.ReadLine();
            Console.WriteLine("Phone:");
            st1.Phone = Console.ReadLine();
            Console.WriteLine("Ngay nhap hoc:");
            st1.CreatedAt = Convert.ToDateTime(Console.ReadLine());
           
            Console.WriteLine("----------------------------------");

            students.Add(st1);
        }


    }
}

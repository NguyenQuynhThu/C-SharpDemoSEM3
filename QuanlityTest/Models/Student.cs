using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanlityTest.Models
{
    class Student
    {
        public string RollNumber { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public enum StudentStatus
        {
            Active = 1,
            Deactive = 0,
        }
        public StudentStatus Status { get; set; }

        public bool IsNewStudent()
        {
            if ((DateTime.Now - CreatedAt).Days >= 60)
            {
                return false;
            }
            return true;
        }

        public bool IsDeactive()
        {
            if (Status == StudentStatus.Active)
            {
                return false;
            }
            return true;
        }
    }

}

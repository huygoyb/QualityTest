using System;
using System.Collections.Generic;

namespace QualityTest.Models
{
    public class Student
    {
        public string RollNumber { get; set; }
        public string FullName { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CreatedAt { get; set; }
        public int Status { get; set; }

        public Student()
        {
            
        }
        

        enum StudentStatus
        {
            Active = 1,
            Deactive = 0
        }

        


    }
    
    
}
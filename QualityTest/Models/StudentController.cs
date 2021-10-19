using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace QualityTest.Models
{
    public class StudentController
    {
        public string RollNumber { get; set; }
        public string FullName { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CreatedAt { get; set; }
        public int Status { get; set; }

        



        public void CreateStudent()
        {
            Console.WriteLine("Nhap ma sinh vien");
            RollNumber = Console.ReadLine();
            Console.WriteLine("Nhap Ho va ten sinh vien");
            FullName = Console.ReadLine();
            Console.WriteLine("Nhap ngay thang nam sinh(dd-mm-yyyy)");
            Birthday = Console.ReadLine();
            Console.WriteLine("Nhap dia chi email");
            Email = Console.ReadLine();
            Console.WriteLine("Nhap so dien thoai");
            Phone = Console.ReadLine();
            Console.WriteLine("Nhap ngay dang ky(dd-mm-yyyy)");
            CreatedAt = Console.ReadLine();
            Console.WriteLine("");
            Status = Convert.ToInt32(Status);
            Console.WriteLine();

        }

        static List<Student> Initialize()
        {
            var student = new List<Student>()
            {
                new Student()
                {
                    RollNumber = "sv01", 
                    FullName = "Nguyen Van A",
                    Birthday = "01-01-2000",
                    Email = "NNY@gmail.com",
                    Phone = "0123456789",
                    CreatedAt = "10-10-2021",
                    Status = 1
                }
            };
            
            return student;
        }

        public void PrintListStudents(List<Student>students )
        {
            foreach (var s in students)
            {
                Console.WriteLine($" {s.RollNumber}," +
                                  $"{s.FullName}," +
                                  $"{s.Birthday}," +
                                  $"{s.Email}," +
                                  $"{s.Phone}," +
                                  $"{s.CreatedAt}," +
                                  $"{s.Status}");
            }
            
        }
    }
    
    
}
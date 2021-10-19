using System;
using System.Collections.Generic;
using QualityTest.Models;

namespace QualityTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StudentController sc = new StudentController();
            
            int choose;
            do
            {
                GenerateMenu();
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        sc.CreateStudent();
                        break;
                    case 2:
                        sc.PrintListStudents(new List<Student>());
                        break;
                    default:
                        Console.WriteLine("nhap sai");
                        break;
                }

            } while (choose !=3);
        }

        static void GenerateMenu()
        {
            Console.WriteLine("Menu gom 2 lua chon:");
            Console.WriteLine("1: Tao moi sinh vien");
            Console.WriteLine("2: Hien thi danh sach sinh vien");
        }
    }
}
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.OnlineLearningPlatform.Context;
using OnlineLearningPlatform.OnlineLearningPlatform.Moduls;
using System;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace OnlineLearningPlatform
{


    namespace OnlineLearningPlatform
    {
        public class Program
        {
            static void Main(string[] args)
            {
                 using OnlineLearningDBContext _context = new OnlineLearningDBContext();



                Student stu = new Student();
                stu.FullName = "ahmed khalid";
                _context.Student.Add(stu);
                _context.SaveChanges();

                Console.Write("Enter Sudent Name: ");
                string stuName = Console.ReadLine();


                Console.Write("Enter Course Name: ");
                string corName = Console.ReadLine();

                Cources cources = new Cources();
                cources.Name = corName;
                cources.StudentId = stu.StudentId;
                _context.cources.Add(cources);
                _context.SaveChanges();

                Console.WriteLine("Cources added successfully to Database ");




               





            }
        }
        }
    }


    

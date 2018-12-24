using EFCoreTutorial.Models;
using System;


namespace EFCoreTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my first EFCore Application:");
           
            using(var context = new SchoolDBContext())
            {
                Console.WriteLine("Adding course...");

                var testCourse = new Course()
                {
                    CourseId = 9999,
                    Title = "EFCore Tutorial",
                    Credits = 9,
                    DepartmentId = 2
                };

                context.Course.Add(testCourse);
                context.SaveChanges();
                Console.WriteLine("Course added");

                var courses = context.Course;

                Console.WriteLine("Listing all courses in Title Order (ASC)");
                foreach(var course in courses)
                {
                    Console.WriteLine($"ID: {course.CourseId}, Title: {course.Title}");
                }

                Console.WriteLine("Deleting CourseId 9999");
                context.Course.Remove(testCourse);

                context.SaveChanges();
                Console.WriteLine("Course removed");

                courses = context.Course;

                Console.WriteLine("Listing all courses in Title Order (ASC)");

                Console.WriteLine("Listing all courses in Title Order (ASC)");
                foreach (var course in courses)
                {
                    Console.WriteLine($"ID: {course.CourseId}, Title: {course.Title}");
                }
            }
        }
    }
}

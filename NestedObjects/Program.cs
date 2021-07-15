using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor currIns = new Instructor()
            {
                FullName = "Joe Man",
                Email = "Joem@gmail.com"
            };

            Student stu1 = new Student()
            {
                FirstName = "Man",
                LastName = "Son",
            };
            Student stu2 = new Student()
            {
                FirstName = "Hammon",
                LastName = "Johnson"
            };
            Student stu3 = new Student()
            {
                FirstName = "Arthur",
                LastName = "Kingof"
            };

            Course testCourse = new Course();
            testCourse.Title = "CPW 212 - Advanced .NET";
            testCourse.Description = "The continuation of the .NET class";
            testCourse.Credits = 5;
            testCourse.ClassInstructor = currIns;
            testCourse.Roster = new List<Student>();

            //Adding the students to course.
            testCourse.Roster.Add(stu1);
            testCourse.Roster.Add(stu2);
            testCourse.Roster.Add(stu3);

            Console.WriteLine(testCourse.Title);
            Console.WriteLine($"Is taught by {testCourse.ClassInstructor.FullName}");
            Console.WriteLine("Currently Enrolled Students:");
            foreach(Student s in testCourse.Roster)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}");
            }
            Console.ReadKey();
        }
    }
}

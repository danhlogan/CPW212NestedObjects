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
            Instructor currInst = new Instructor()
            {
                FullName = "Homer Simpson",
                Email = "Homer.Simpson@cptc.edu"
            };

            Student s1 = new Student()
            {
                FirstName = "Jim",
                LastName = "Halpert"
            };

            Student s2 = new Student()
            {
                FirstName = "Dave",
                LastName = "Port"
            };

            Student s3 = new Student()
            {
                FirstName = "Allison",
                LastName = "Murphy"
            };

            Course testCourse = new Course();

            testCourse.Title = "CPW 212 - ADV .NET";
            testCourse.Description = "Lorem ipsum";
            testCourse.Credits = 5;
            testCourse.CourseInstructor = currInst;
            testCourse.Roster = new List<Student>();

            testCourse.Roster.Add(s1);
            testCourse.Roster.Add(s2);
            testCourse.Roster.Add(s3);

            Console.WriteLine(testCourse.Title);
            Console.WriteLine("is taught by " + testCourse.CourseInstructor.FullName );

            Console.WriteLine("Currently enrolled students");
            foreach(Student s in testCourse.Roster)
            {
                Console.WriteLine(s.FirstName + " " + s.LastName);
            }

            Console.ReadKey();

        }
    }
}

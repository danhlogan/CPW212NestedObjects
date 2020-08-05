using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Course
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public byte Credits { get; set; }

        /// <summary>
        /// Instructor that teaches the course
        /// </summary>
        public Instructor CourseInstructor { get; set; }


        /// <summary>
        /// All the students currently enrolled in the class
        /// </summary>
        public List<Student> Roster { get; set; }


    }
}

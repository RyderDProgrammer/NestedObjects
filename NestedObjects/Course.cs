using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents a singular course that a instructor can teach and a student can take.
    /// </summary>
    class Course
    {
        /// <summary>
        /// The full title of the course.
        /// EX. CPW 212 - Advanced .NET Programming
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The official course description that student is taking.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The amount of credits given for the course
        /// </summary>
        public byte Credits { get; set; }

        /// <summary>
        /// The instructor that teaches the course
        /// </summary>
        public Instructor ClassInstructor { get; set; }

        /// <summary>
        /// Contains a list of all the current students in the course.
        /// </summary>
        public List<Student> Roster { get; set; }
    }
}

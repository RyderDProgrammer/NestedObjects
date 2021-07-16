using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents a singular student
    /// </summary>
    class Student
    {
        /// <summary>
        /// The students legal first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The students legal last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The courses that the student is enrolled in.
        /// </summary>
        public List<Course> Schedule { get; set; }
    }
}

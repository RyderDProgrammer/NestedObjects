using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents a single instructor with their fullname and company provided email.
    /// </summary>
    class Instructor
    {
        /// <summary>
        /// The instructors full legal name both first and last.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Company email address
        /// </summary>
        public string Email { get; set; }
    }
}

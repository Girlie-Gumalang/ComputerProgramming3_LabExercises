using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNamespace
{
    public class StudentInfo
    {
        // Private fields
        private string studentID;
        private string firstName;
        private string lastName;

        // Contructor with empty strings
        public StudentInfo() 
        {
            this.studentID = "";
            this.firstName = "";
            this.lastName = "";
        }

        // Overloaded constructor with parameters
        public StudentInfo(string studentID, string firstName, string lastName)
        {
            this.studentID = studentID;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // Property for studentID with get and set methods
        public string StudentID
        {
            get { return studentID; }
            set { this.studentID = value; }
        }

        // Property for firstName with get and set methods
        public string FirstName
        {
            get { return firstName; }
            set { this.firstName = value; }
        }

        // Property for lastName with get and set methods
        public string LastName
        {
            get { return lastName; }
            set { this.lastName = value; }
        }
    }
}

using System;
using EmployeeInterface;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace
{
    public class PartTimeEmployee : IEmployee
    {
        // Private fields 
        private string first_name;
        private string last_name;
        private string department;
        private string job_title;
        private double basic_salary;

        // Constructor
        public PartTimeEmployee(string fName, string lName, string dept, string job)
        {
            this.first_name = fName;
            this.last_name = lName;
            this.department = dept;
            this.job_title = job;
            this.basic_salary = 0;  // Initialize to 0
        }

        // Public properties with both getters and setters (as required by the interface)
        public string FirstName
        {
            get { return first_name; }
            set { first_name = value; }
        }

        public string LastName
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string JobTitle
        {
            get { return job_title; }
            set { job_title = value; }
        }

        public double BasicSalary
        {
            get { return basic_salary; }
            set { basic_salary = value; }
        }

        // Method to compute salary
        public void ComputeSalary(int hoursWorked, double ratePerHour)
        {
            basic_salary = hoursWorked * ratePerHour;
        }

        // Method to get salary
        public double GetSalary()
        {
            return basic_salary;
        }
    }
}

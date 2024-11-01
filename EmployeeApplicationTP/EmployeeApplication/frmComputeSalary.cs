using System;
using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve input from the form's textboxes
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string department = txtDepartment.Text;
            string jobTitle = txtJobTitle.Text;
            int hoursWorked = int.Parse(txtHoursWorked.Text);
            double ratePerHour = double.Parse(txtRatePerHour.Text);

            // Create a new PartTimeEmployee object
            PartTimeEmployee employee = new PartTimeEmployee(firstName, lastName, department, jobTitle);

            // Compute the salary
            employee.ComputeSalary(hoursWorked, ratePerHour);

            // Display the employee's details below the Compute button
            lblFirstName.Text = $"First name:   {firstName}";
            lblLastName.Text = $"Last name:   {lastName}";
            lblComputedSalary.Text = $"Basic Salary:   {employee.GetSalary()}";
        }
    }
}

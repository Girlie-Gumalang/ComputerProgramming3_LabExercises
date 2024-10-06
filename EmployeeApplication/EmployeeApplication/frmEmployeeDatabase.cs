using EmployeeNamespace;

using System.Data;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        private DataTable table; // hold employee data
        public frmEmployeeDatabase()
        {
            InitializeComponent();

            // Initialize DataTable with columns
            table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("firstName", typeof(string));
            table.Columns.Add("lastName", typeof(string));
            table.Columns.Add("position", typeof(string));

            dgvEmployee.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create new Employee object with input values
            Employee employee = new Employee(int.Parse(txtEmployeeID.Text), txtFirstName.Text, txtLastName.Text, txtPosition.Text);
           
            // Add new employee data to DataTable
            table.Rows.Add(employee.EmployeeID, employee.FirstName, employee.LastName, employee.Position);
        }
    }
}

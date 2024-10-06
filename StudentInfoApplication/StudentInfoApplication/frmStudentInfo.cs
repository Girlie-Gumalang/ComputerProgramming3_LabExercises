using StudentNamespace;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfo student = new StudentInfo(txtStudentID.Text, txtFirstName.Text, txtLastName.Text);

            // Add the values to its proper list boxes
            lbStudentID.Items.Add(student.StudentID);
            lbFirstName.Items.Add(student.FirstName); 
            lbLastName.Items.Add(student.LastName);

        }
    }
}

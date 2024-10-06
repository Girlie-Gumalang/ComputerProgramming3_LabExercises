using System.Collections;
using System.Windows.Forms;

namespace StudentRegisterApplication
{
    public partial class Form1 : Form
    {
        string gender;

        public Form1()
        {
            InitializeComponent();
            // Define month names and programs for ComboBoxes
            string[] monthNames = new string[] {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"};

            // List of degree programs
            ArrayList degreePrograms = new ArrayList()
            {
                "Bachelor of Science in Accountancy",
                "Bachelor of Science in Business Administration",
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Hospitality Management",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Tourism Management",
                "Bachelor of Arts in Communication",
                "Bachelor of Multimedia Arts"
            };

            // Set day in the ComboBox (1 to 31)
            for (int day = 1; day <= 31; day++)
            {
                cbDay.Items.Add(day);
            }

            // Set year in the ComboBox from 1950 to 2024
            for (int year = 1990; year <= 2024; year++)
            {
                cbYear.Items.Add(year);
            }

            // Set month in the ComboBox
            foreach (string month in monthNames)
            {
                cbMonth.Items.Add(month);
            }

            // Set program in the ComboBox
            foreach (string program in degreePrograms)
            {
                cbProgram.Items.Add(program);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Read input fields from text boxes
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;
            string lastName = txtLastName.Text;

            string day = cbDay.SelectedItem.ToString();
            string month = cbMonth.SelectedItem.ToString();
            string year = cbYear.SelectedItem.ToString();
            string program = cbProgram.SelectedItem.ToString();

            // Display three overloaded methods with parameters
            ShowMessage(firstName, middleName, lastName, gender, day, month, year, program);
            ShowMessage(firstName, middleName, lastName, program);
            ShowMessage(firstName, lastName, program);
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
             gender = "Male";
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        // Message with all details
        private void ShowMessage(string fName, string mName, string lName, string gender, string day, string month, string year, string program)
        {
            MessageBox.Show($"Student name: {fName} {mName} {lName}\n" +
                            $"Gender: {gender}\n" +
                            $"Date of birth: {day}/{month}/{year}\n" +
                            $"Program: {program}");
        }

        // Message with first name, middle name, last name, and program
        private void ShowMessage(string fName, string mName, string lName, string program)
        {
            MessageBox.Show($"Student name: {fName} {mName} {lName}\n" +
                            $"Program: {program}");
        }

        // Message with first name, last name, and program
        private void ShowMessage(string fName, string lName, string program)
        {
            MessageBox.Show($"Student name: {fName} {lName}\n" +
                            $"Program: {program}");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            // OpenFileDialog to allow image selection
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "C:\\",
                Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png"
            };

            // Check if a file was selected
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Set PictureBox SizeMode to stretch image so that the entire image fits
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                // Load the selected image into the PictureBox
                pictureBox1.Image = new Bitmap(filePath);
            }
        }

    }
}
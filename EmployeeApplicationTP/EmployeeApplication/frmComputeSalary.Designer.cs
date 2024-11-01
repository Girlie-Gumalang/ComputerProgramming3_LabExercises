namespace EmployeeApplication
{
    partial class frmComputeSalary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtDepartment = new TextBox();
            label4 = new Label();
            txtJobTitle = new TextBox();
            label5 = new Label();
            txtRatePerHour = new TextBox();
            label6 = new Label();
            txtHoursWorked = new TextBox();
            button1 = new Button();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblComputedSalary = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(95, 29);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(12, 52);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(217, 26);
            txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(235, 20);
            label2.Name = "label2";
            label2.Size = new Size(94, 29);
            label2.TabIndex = 2;
            label2.Text = "Last name";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(235, 52);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(217, 26);
            txtLastName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(106, 29);
            label3.TabIndex = 4;
            label3.Text = "Department";
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepartment.Location = new Point(12, 113);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(217, 26);
            txtDepartment.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(235, 81);
            label4.Name = "label4";
            label4.Size = new Size(80, 29);
            label4.TabIndex = 6;
            label4.Text = "Job Title";
            // 
            // txtJobTitle
            // 
            txtJobTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtJobTitle.Location = new Point(235, 113);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(217, 26);
            txtJobTitle.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 195);
            label5.Name = "label5";
            label5.Size = new Size(119, 29);
            label5.TabIndex = 8;
            label5.Text = "Rate per hour";
            // 
            // txtRatePerHour
            // 
            txtRatePerHour.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRatePerHour.Location = new Point(12, 227);
            txtRatePerHour.Name = "txtRatePerHour";
            txtRatePerHour.Size = new Size(217, 26);
            txtRatePerHour.TabIndex = 9;
            txtRatePerHour.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(235, 195);
            label6.Name = "label6";
            label6.Size = new Size(163, 29);
            label6.TabIndex = 10;
            label6.Text = "Total hours worked";
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoursWorked.Location = new Point(235, 227);
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(217, 26);
            txtHoursWorked.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(151, 259);
            button1.Name = "button1";
            button1.Size = new Size(138, 31);
            button1.TabIndex = 12;
            button1.Text = "Compute Salary";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(12, 319);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(260, 29);
            lblFirstName.TabIndex = 13;
            lblFirstName.Text = "First name:           <first name here>";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(12, 348);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(255, 29);
            lblLastName.TabIndex = 14;
            lblLastName.Text = "Last name:          <last name here>";
            // 
            // lblComputedSalary
            // 
            lblComputedSalary.AutoSize = true;
            lblComputedSalary.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComputedSalary.Location = new Point(12, 377);
            lblComputedSalary.Name = "lblComputedSalary";
            lblComputedSalary.Size = new Size(175, 29);
            lblComputedSalary.TabIndex = 15;
            lblComputedSalary.Text = "Basic Salary:      00.00";
            // 
            // frmComputeSalary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 450);
            Controls.Add(lblComputedSalary);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(button1);
            Controls.Add(txtHoursWorked);
            Controls.Add(label6);
            Controls.Add(txtRatePerHour);
            Controls.Add(label5);
            Controls.Add(txtJobTitle);
            Controls.Add(label4);
            Controls.Add(txtDepartment);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Name = "frmComputeSalary";
            Text = "Employee Salary Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtDepartment;
        private Label label4;
        private TextBox txtJobTitle;
        private Label label5;
        private TextBox txtRatePerHour;
        private Label label6;
        private TextBox txtHoursWorked;
        private Button button1;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblComputedSalary;
    }
}

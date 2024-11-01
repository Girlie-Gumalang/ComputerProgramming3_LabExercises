namespace StudentRegisterApplication
{
    partial class Form1
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
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label4 = new Label();
            txtMiddleName = new TextBox();
            label5 = new Label();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            label6 = new Label();
            cbDay = new ComboBox();
            cbMonth = new ComboBox();
            cbYear = new ComboBox();
            label7 = new Label();
            cbProgram = new ComboBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(287, 25);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Last name *";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(12, 75);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(287, 28);
            txtLastName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 3;
            label3.Text = "First name *";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(12, 129);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(287, 28);
            txtFirstName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 160);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 5;
            label4.Text = "Middle name *";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleName.Location = new Point(12, 183);
            txtMiddleName.Multiline = true;
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(287, 28);
            txtMiddleName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 214);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 7;
            label5.Text = "Gender *";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbMale.Location = new Point(99, 211);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(62, 25);
            rbMale.TabIndex = 8;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += rbMale_CheckedChanged;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbFemale.Location = new Point(167, 211);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 25);
            rbFemale.TabIndex = 9;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.CheckedChanged += rbFemale_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 250);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 10;
            label6.Text = "Date of birth *";
            // 
            // cbDay
            // 
            cbDay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDay.FormattingEnabled = true;
            cbDay.Location = new Point(12, 273);
            cbDay.Name = "cbDay";
            cbDay.Size = new Size(81, 29);
            cbDay.TabIndex = 11;
            cbDay.Text = "-Day-";
            // 
            // cbMonth
            // 
            cbMonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMonth.FormattingEnabled = true;
            cbMonth.Location = new Point(99, 273);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(104, 29);
            cbMonth.TabIndex = 12;
            cbMonth.Text = "-Month-";
            // 
            // cbYear
            // 
            cbYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(209, 273);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(90, 29);
            cbYear.TabIndex = 13;
            cbYear.Text = "-Year-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 305);
            label7.Name = "label7";
            label7.Size = new Size(156, 20);
            label7.TabIndex = 14;
            label7.Text = "Program to apply *";
            // 
            // cbProgram
            // 
            cbProgram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(12, 328);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(399, 29);
            cbProgram.TabIndex = 15;
            cbProgram.Text = "-Select program-";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 363);
            button1.Name = "button1";
            button1.Size = new Size(170, 32);
            button1.TabIndex = 16;
            button1.Text = "Register student";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Location = new Point(332, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 207);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(389, 265);
            button2.Name = "button2";
            button2.Size = new Size(112, 36);
            button2.TabIndex = 18;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 434);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(cbProgram);
            Controls.Add(label7);
            Controls.Add(cbYear);
            Controls.Add(cbMonth);
            Controls.Add(cbDay);
            Controls.Add(label6);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(label5);
            Controls.Add(txtMiddleName);
            Controls.Add(label4);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtFirstName;
        private Label label4;
        private TextBox txtMiddleName;
        private Label label5;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Label label6;
        private ComboBox cbDay;
        private ComboBox cbMonth;
        private ComboBox cbYear;
        private Label label7;
        private ComboBox cbProgram;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
    }
}

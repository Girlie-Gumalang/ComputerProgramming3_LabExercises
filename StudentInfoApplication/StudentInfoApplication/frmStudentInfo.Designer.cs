namespace StudentInfoApplication
{
    partial class frmStudentInfo
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
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            txtStudentID = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lbStudentID = new ListBox();
            lbFirstName = new ListBox();
            lbLastName = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 24);
            label1.TabIndex = 0;
            label1.Text = "Student ID *";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(695, 70);
            button1.Name = "button1";
            button1.Size = new Size(85, 32);
            button1.TabIndex = 1;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(270, 9);
            label2.Name = "label2";
            label2.Size = new Size(108, 24);
            label2.TabIndex = 2;
            label2.Text = "Last name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(528, 9);
            label3.Name = "label3";
            label3.Size = new Size(110, 24);
            label3.TabIndex = 3;
            label3.Text = "First name *";
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentID.Location = new Point(12, 36);
            txtStudentID.Multiline = true;
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(252, 28);
            txtStudentID.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(270, 36);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(252, 28);
            txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(528, 36);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(252, 28);
            txtFirstName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 122);
            label4.Name = "label4";
            label4.Size = new Size(128, 24);
            label4.TabIndex = 7;
            label4.Text = "Student ID List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(282, 122);
            label5.Name = "label5";
            label5.Size = new Size(133, 24);
            label5.TabIndex = 8;
            label5.Text = "First Name List";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(528, 122);
            label6.Name = "label6";
            label6.Size = new Size(131, 24);
            label6.TabIndex = 9;
            label6.Text = "Last Name List";
            // 
            // lbStudentID
            // 
            lbStudentID.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbStudentID.FormattingEnabled = true;
            lbStudentID.ItemHeight = 24;
            lbStudentID.Location = new Point(34, 149);
            lbStudentID.Name = "lbStudentID";
            lbStudentID.Size = new Size(230, 244);
            lbStudentID.TabIndex = 10;
            // 
            // lbFirstName
            // 
            lbFirstName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFirstName.FormattingEnabled = true;
            lbFirstName.ItemHeight = 24;
            lbFirstName.Location = new Point(282, 149);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(230, 244);
            lbFirstName.TabIndex = 11;
            // 
            // lbLastName
            // 
            lbLastName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLastName.FormattingEnabled = true;
            lbLastName.ItemHeight = 24;
            lbLastName.Location = new Point(528, 149);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(230, 244);
            lbLastName.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 450);
            Controls.Add(lbLastName);
            Controls.Add(lbFirstName);
            Controls.Add(lbStudentID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox txtStudentID;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox lbStudentID;
        private ListBox lbFirstName;
        private ListBox lbLastName;
    }
}

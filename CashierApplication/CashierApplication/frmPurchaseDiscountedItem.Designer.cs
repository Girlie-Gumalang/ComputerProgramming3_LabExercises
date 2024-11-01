namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
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
            btnCompute = new Button();
            btnSubmit = new Button();
            label1 = new Label();
            txtItem = new TextBox();
            label2 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            txtDiscount = new TextBox();
            label4 = new Label();
            txtQuantity = new TextBox();
            lblTotalAmount = new Label();
            label6 = new Label();
            txtPaymentReceived = new TextBox();
            lblChange = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitApplicationToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.Silver;
            btnCompute.FlatStyle = FlatStyle.Flat;
            btnCompute.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompute.Location = new Point(170, 174);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(111, 37);
            btnCompute.TabIndex = 0;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Silver;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(334, 291);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(93, 35);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(60, 30);
            label1.TabIndex = 2;
            label1.Text = "Item:";
            // 
            // txtItem
            // 
            txtItem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtItem.Location = new Point(12, 80);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(252, 33);
            txtItem.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 116);
            label2.Name = "label2";
            label2.Size = new Size(63, 30);
            label2.TabIndex = 4;
            label2.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(72, 119);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(192, 33);
            txtPrice.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(270, 47);
            label3.Name = "label3";
            label3.Size = new Size(135, 30);
            label3.TabIndex = 6;
            label3.Text = "Discount (%):";
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiscount.Location = new Point(270, 80);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(159, 33);
            txtDiscount.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(270, 122);
            label4.Name = "label4";
            label4.Size = new Size(98, 30);
            label4.TabIndex = 8;
            label4.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(365, 123);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(64, 33);
            txtQuantity.TabIndex = 9;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(49, 222);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(140, 30);
            lblTotalAmount.TabIndex = 10;
            lblTotalAmount.Text = "Total amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 296);
            label6.Name = "label6";
            label6.Size = new Size(181, 30);
            label6.TabIndex = 11;
            label6.Text = "Payment received:";
            // 
            // txtPaymentReceived
            // 
            txtPaymentReceived.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPaymentReceived.Location = new Point(190, 293);
            txtPaymentReceived.Name = "txtPaymentReceived";
            txtPaymentReceived.Size = new Size(140, 33);
            txtPaymentReceived.TabIndex = 12;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChange.Location = new Point(88, 346);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(101, 30);
            lblChange.TabIndex = 13;
            lblChange.Text = "Changed:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(439, 28);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitApplicationToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(44, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(183, 24);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitApplicationToolStripMenuItem
            // 
            exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            exitApplicationToolStripMenuItem.Size = new Size(183, 24);
            exitApplicationToolStripMenuItem.Text = "Exit Application";
            exitApplicationToolStripMenuItem.Click += exitApplicationToolStripMenuItem_Click;
            // 
            // frmPurchaseDiscountedItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 450);
            Controls.Add(lblChange);
            Controls.Add(txtPaymentReceived);
            Controls.Add(label6);
            Controls.Add(lblTotalAmount);
            Controls.Add(txtQuantity);
            Controls.Add(label4);
            Controls.Add(txtDiscount);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(txtItem);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Controls.Add(btnCompute);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPurchaseDiscountedItem";
            Text = "Purchase Discounted Item";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCompute;
        private Button btnSubmit;
        private Label label1;
        private TextBox txtItem;
        private Label label2;
        private TextBox txtPrice;
        private Label label3;
        private TextBox txtDiscount;
        private Label label4;
        private TextBox txtQuantity;
        private Label lblTotalAmount;
        private Label label6;
        private TextBox txtPaymentReceived;
        private Label lblChange;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitApplicationToolStripMenuItem;
    }
}

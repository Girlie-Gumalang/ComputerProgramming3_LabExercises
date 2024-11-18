namespace Inventory
{
    partial class frmAddProduct
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtSellPrice = new TextBox();
            cbCategory = new ComboBox();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            label8 = new Label();
            richTxtDescription = new RichTextBox();
            btnAddProduct = new Button();
            gridViewProductList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 153);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Mfg. Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 191);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 4;
            label5.Text = "Exp. Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 225);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 5;
            label6.Text = "Qty.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(11, 259);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 6;
            label7.Text = "Sell Price";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(111, 72);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(262, 26);
            txtProductName.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(111, 219);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(262, 26);
            txtQuantity.TabIndex = 8;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSellPrice.Location = new Point(111, 256);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(262, 26);
            txtSellPrice.TabIndex = 9;
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(111, 109);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(262, 28);
            cbCategory.TabIndex = 10;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPickerMfgDate.Location = new Point(111, 148);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(262, 26);
            dtPickerMfgDate.TabIndex = 11;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPickerExpDate.Location = new Point(111, 186);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(262, 26);
            dtPickerExpDate.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(402, 75);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 13;
            label8.Text = "Description";
            // 
            // richTxtDescription
            // 
            richTxtDescription.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTxtDescription.Location = new Point(402, 109);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(386, 173);
            richTxtDescription.TabIndex = 14;
            richTxtDescription.Text = "";
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(224, 224, 224);
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddProduct.Location = new Point(680, 288);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(108, 35);
            btnAddProduct.TabIndex = 15;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(11, 329);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.Size = new Size(777, 191);
            gridViewProductList.TabIndex = 16;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 532);
            Controls.Add(gridViewProductList);
            Controls.Add(btnAddProduct);
            Controls.Add(richTxtDescription);
            Controls.Add(label8);
            Controls.Add(dtPickerExpDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(cbCategory);
            Controls.Add(txtSellPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddProduct";
            Text = "Inventory";
            Load += frmAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private TextBox txtSellPrice;
        private ComboBox cbCategory;
        private DateTimePicker dtPickerMfgDate;
        private DateTimePicker dtPickerExpDate;
        private Label label8;
        private RichTextBox richTxtDescription;
        private Button btnAddProduct;
        private DataGridView gridViewProductList;
    }
}

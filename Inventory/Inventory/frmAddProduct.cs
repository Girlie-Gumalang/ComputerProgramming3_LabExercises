using System.CodeDom.Compiler;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        private int _Quantity;
        private double _SellPrice;
        private BindingSource showProductList;

        public frmAddProduct()
        {
            InitializeComponent();
            // Initialize the BindingSource
            showProductList = new BindingSource(); 
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            // Array of product categories
            string[] ListOfProductCategory = {
                "Beverages", "Bread / Bakery", "Canned / Jarred Goods", "Dairy", "Frozen Goods", "Meat", "Personal Care", "Other" 
            };

            // Add categories to the ComboBox
            foreach (string lopc in ListOfProductCategory)
            {
                cbCategory.Items.Add(lopc);
            }
        }

        // Validates product name (letters only)
        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                throw new StringFormatException("Product name should contain only letters.");
            return name;
        }

        // Validates quantity (positive integers only)
        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]"))
                throw new NumberFormatException("Quantity should be a valid integer.");
            return Convert.ToInt32(qty);
        }

        // Validates selling price (positive numbers with optional decimals)
        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                throw new CurrencyFormatException("Selling price should be a valid positive number.");
            return Convert.ToDouble(price);
        }

        // Handles the Add Product button click event
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect and validate user input
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);

                // Add validated product to the list
                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate,
                _ExpDate, _SellPrice, _Quantity, _Description));

                // Display product list in the DataGridView
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
            }
            catch (NumberFormatException nfe)
            {
                MessageBox.Show($"Number Format Error: {nfe.Message}", "Error!");
            }
            catch (StringFormatException sfe)
            {
                MessageBox.Show($"String Format Error: {sfe.Message}", "Error!");
            }         
            catch (CurrencyFormatException cfe)
            {
                MessageBox.Show($"Currency Format Error: {cfe.Message}", "Error!");
            }
            finally
            {
                MessageBox.Show("Validation process completed!");
            }
        }
    }

    // Custom exception for invalid numeric values
    class NumberFormatException : Exception
    {
        public NumberFormatException(string quantity) : base(quantity) { }
    }

    // Custom exception for invalid string values
    class StringFormatException : Exception
    {
        public StringFormatException(string name) : base(name) { }
    }

    // Custom exception for invalid currency values
    class CurrencyFormatException : Exception
    {
        public CurrencyFormatException(string price) : base(price) { }
    }
}
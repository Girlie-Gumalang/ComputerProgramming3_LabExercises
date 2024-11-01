using ItemNamespace;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {    
        private DiscountedItem? discountedItem;  
        private frmLoginAccount loginForm; 

        public frmPurchaseDiscountedItem(frmLoginAccount loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm; 
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            // Get inputs from text boxes
            string itemName = txtItem.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            double discount = Convert.ToDouble(txtDiscount.Text);

            // Create a new DiscountedItem object
            discountedItem = new DiscountedItem(itemName, price, quantity, discount);

            // Compute the total price and display it in lblTotalAmount
            double totalAmount = discountedItem.getTotalPrice();
            lblTotalAmount.Text = $"Total amount:   {totalAmount:F2}";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Prompt the user if they click submit before they calculate the total value
            if (discountedItem == null)
            {
                MessageBox.Show("Please compute the total price first.");
                return;
            }

            try
            {
                double paymentReceived = Convert.ToDouble(txtPaymentReceived.Text);
                discountedItem.setPayment(paymentReceived);
                double change = discountedItem.getChange();

                lblChange.Text = $"Change:   {change:F2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid payment amount.");
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {    
            this.Hide(); // Hides the current form
            loginForm.Show(); // Displays the login form
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Closing all windows
        }
    }
}

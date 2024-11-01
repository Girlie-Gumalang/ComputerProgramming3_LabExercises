using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    public class DiscountedItem : Item
    {
        // Private fields 
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        // Constructor that initializes the DiscountedItem and calls base class constructor
        public DiscountedItem(string name, double price, int quantity, double discount)
           : base(name, price, quantity)
        {
            this.item_discount = discount;
            this.discounted_price = 0.0;
            this.payment_amount = 0.0;
            this.change = 0.0;
        }

        // Override method to calculate the total price after discount
        public override double getTotalPrice()
        {
            discounted_price = item_price - (item_price * (item_discount * 0.01));
            Total_Price = item_quantity * (discounted_price);
            return Total_Price;
        }

        // Override method to set the payment and calculate the change
        public override void setPayment(double amount)
        {
            payment_amount = amount;
            change = payment_amount - Total_Price;
        }

        // Method to return the change amount
        public double getChange()
        {
            return change;
        }

        // Properties for discount, discounted price, payment, and change
        public double Item_Discount
        {
            get { return item_discount; }
            set { item_discount = value; }
        }

        public double Discounted_Price
        {
            get { return discounted_price; }
            set { discounted_price = value; }
        }

        public double Payment_Amount
        {
            get { return payment_amount; }
            set { payment_amount = value; }
        }

        public double Change
        {
            get { return change; }
            set { change = value; }
        }
    }
}

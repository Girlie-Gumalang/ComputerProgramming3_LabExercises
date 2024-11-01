using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    public abstract class Item
    {
        // Protected fields accessible by derived classes
        protected string item_name;
        protected double item_price;
        protected int item_quantity;

        // Private field to store total price
        private double total_price;

        // Constructor to initialize item properties
        public Item(string name, double price, int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantity = quantity;
        }

        // Abstract methods that will be implemented by derived classes
        public abstract double getTotalPrice();
        public abstract void setPayment(double amount);

        // Property to get and set total price
        public double Total_Price
        {
            get { return total_price; }
            set { total_price = value; }
        }

        // Property to get and set item name
        public string Item_Name
        {
            get { return item_name; }
            set { item_name = value; }
        }

        // Property to get and set item price
        public double Item_Price
        {
            get { return item_price; }
            set { item_price = value; }
        }

        // Property to get and set item quantity
        public int Item_Quantity
        {
            get { return item_quantity; }
            set { item_quantity = value; }
        }

    }
}

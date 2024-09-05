using System;

namespace AppleCost
{
    class AppleCostProgram
    {
        static void Main(string[] args)
        {
            // Initialize constant for the price of an apple each
            const double APPLE_COSTS = 32.50;
            // Declare variable for calculation of price of purchased apple
            double totalPrice;

            // Ask the user to enter number of apples like to purchase
            Console.Write("Enter the number of apples you want to purchase: ");
            int appleQuantity = Convert.ToInt32(Console.ReadLine());

            // Calculate the total price 
            totalPrice = APPLE_COSTS * appleQuantity;

            // Display number of apples and its total price
            Console.WriteLine($"The total price of {appleQuantity} apples is {totalPrice}.");
            // Total price is converted to whole numbers through casting
            Console.WriteLine("The value of the converted price is " + (int)totalPrice + ".\n");

        }
    }
}

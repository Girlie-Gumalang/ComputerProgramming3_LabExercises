using System;

namespace DataTypesApp
{
     class DataTypesProgram
    {
        static void Main(string[] args)
        {
            //Initialize fruit names to a constant because it doesn't change as it's the only product being offered
            const string Apple = "Apple", Grape = "Grape", Mango = "Mango", Lanzones = "Lanzones", Strawberry = "Strawberry";
            //Greeting message 
            Console.WriteLine("Welcome to Fruit Corner!\n");
            //Show the products and its prices
            Console.WriteLine("====== Available Items ======");
            Console.WriteLine("Products\t\tPrices");
            Console.WriteLine($"{Apple}   \t\t25.75\n" + $"{Grape}   \t\t30.25\n" + $"{Mango}   \t\t40.50\n" +
                              $"{Lanzones}\t\t65.50\n" + $"{Strawberry}\t\t80.75\n");

            //Initiliaze variable for the price of each fruit which means we assigned a value
            double applePrice = 25.75, grapePrice = 30.25, mangoPrice = 40.50, lanzonesPrice = 65.50, strawberryPrice = 80.75;
            
            //Ask the user how many fruits he/she will buy
            Console.WriteLine("------------------------------");
            Console.Write($"Enter the pieces of {Apple}: ");
            int appleQuantity = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter the pieces of {Grape}: ");
            int grapeQuantity = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter the pieces of {Mango}: ");
            int mangoQuantity = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter the pieces of {Lanzones}: ");
            int lanzonesQuantity = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter the pieces of {Strawberry}: ");
            int strawberryQuantity = Convert.ToInt32(Console.ReadLine());

            //Initialize variable to calculate the total price of each fruit
            double totalApplePrice = applePrice * appleQuantity;
            double totalGrapePrice = grapePrice * grapeQuantity;
            double totalMangoPrice = mangoPrice * mangoQuantity;
            double totalLanzonesPrice = lanzonesPrice * lanzonesQuantity;   
            double totalStrawberryPrice = strawberryPrice * strawberryQuantity;

            //Calculate the total price of purchases and then convert to integer
            double totalAmount = totalApplePrice + totalGrapePrice + totalMangoPrice + totalLanzonesPrice + totalStrawberryPrice;
            int convertedPrice = (int)totalAmount;

            //Generate Receipt
            Console.WriteLine("\n==============================\n" +
                              "         Cash Receipt         \n" +
                              "==============================\n");
            Console.WriteLine("Description\tQTY\tPrice");
            Console.WriteLine($"{Apple}\t\t{appleQuantity}\t{totalApplePrice}\n" +
                              $"{Grape}\t\t{grapeQuantity}\t{totalGrapePrice}\n" + 
                              $"{Mango}\t\t{mangoQuantity}\t{totalMangoPrice}\n" +
                              $"{Lanzones}\t{lanzonesQuantity}\t{totalLanzonesPrice}\n" +
                              $"{Strawberry}\t{strawberryQuantity}\t{totalStrawberryPrice}\n");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Total Price\t\t" + totalAmount + 
                              "\nConverted Price\t\t" + convertedPrice);
            Console.WriteLine("------------------------------\n" +
                              "           Thank you!         \n" +
                              "------------------------------\n");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

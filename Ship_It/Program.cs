using System;
using System.Runtime.CompilerServices;

namespace Ship_It
{
    internal class Program
    {
        private static bool isRunning;
               
        static void Main(string[] args)
        {
            isRunning = true;
            while (isRunning)
            {
                runMenu();
            }
        }
        private static bool runMenu()
        {
            string choice = String.Empty;
            Console.WriteLine("Choose from the following options:\n");
            Console.WriteLine("1. Add a Bicycle to the shipment ");
            Console.WriteLine("2. Add a Baseball Glove to the Shipment");
            Console.WriteLine("3. Add a Lawn Mower to the shipment ");
            Console.WriteLine("4. Add Crackers to the shipment ");
            Console.WriteLine("5. List Shipment Items");
            Console.WriteLine("6. Compute Shipping Charges");
            Console.WriteLine("7. Exit Program");
            choice = Console.ReadLine();
           
            switch (choice)
            {
                //add items to list 
               case "1":
                    addToList(new Bicycles());                    
                    return true; 
               case "2":
                    addToList(new BaseballGlove());
                    return true;
               case"3":
                    addToList(new LawnMower());
                    return true;
               case"4":
                   addToList(new Crackers());
                    return true;
               case "5":
                    Console.WriteLine(Shipper.ShippingManifest());
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadLine();
                    return true;
               case "6":
                    Console.WriteLine("Total shipping costs for this order are $" + Shipper.CalculateTotal());                  
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadLine();
                    return true;
               case "7":
                    Console.WriteLine("Closing Program");
                    Console.ReadLine();
                    isRunning = false;
                    return isRunning;
                default:
                    Console.WriteLine("Please enter an apropriate response");
                    Console.ReadLine();
                    return true;
            }
        }      
        private static void addToList(IShippable item)
        {
            Shipper.Add(item);
            Console.WriteLine("1 "+ item.Product +" has been added");
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }
    }
}

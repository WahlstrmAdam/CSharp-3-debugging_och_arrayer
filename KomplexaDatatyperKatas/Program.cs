﻿using System;
using System.Collections.Generic;

namespace KomplexaDatatyperKata
{
    class Program
    {
        public static void Main(string[] args)
        {

            Delivery order = new Delivery(ProductName: "trampoline", 3100, 73217418, "Fredag, 18:00", 50);

            List<Delivery> orders = new List<Delivery>();

            orders.Add( new Delivery(ProductName:"trampolin"));


            while (true)
            {
                Console.Clear();

                Console.WriteLine("1: Order an electric bicycle");
                Console.WriteLine("2: Order a trampoline");
                Console.WriteLine("3: Order a bouquet");
                Console.WriteLine("4: Order something else");
                Console.WriteLine("5: Show all orders");
                Console.WriteLine("6: Show amount of each order");
                Console.WriteLine("7: Exit");

                Console.Write("Type option and press enter:");
                int choice = int.Parse(Console.ReadLine());

                Console.Clear();

                if (choice == 1)
                {

                }
                else if (choice == 2)
                {

                }
                else if(choice == 7)
                {
                    break;
                }
            }
        }
    }
}

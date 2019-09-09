using System;
using System.Collections.Generic;
using System.Threading;
using ArrivalStation.ServiceReference1;

namespace ArrivalStation
{
    class ArrivalStationMain
    {
        private static WarehouseWSClient client;
        private static Random rnd = new Random();

        private static void PrintMenu()
        {
            Console.WriteLine("1. Insert random pallet");
            Console.WriteLine("2. Insert custom pallet.");
            Console.WriteLine("3. Generate truck");
            Console.WriteLine("4. Exit");
        }

        public static void StartMenu()
        {
            PrintMenu();
            string choice = Console.ReadLine();
            while (choice != "4")
            {
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Creating a random pallet");
                        InsertRandomPallet();
                        Console.WriteLine("Done!");
                        break;
                    case "2":
                        InsertCustomPallet();
                        Console.WriteLine("Pallet inserted!");
                        break;
                    case "3":
                        Console.WriteLine("Creating truck...");
                        CreateTruck();
                        Console.WriteLine("Done!");
                        break;
                    case "4":
                        break;
                    default:
                        break;
                }
                PrintMenu();
                choice = Console.ReadLine();
            }
            Console.WriteLine("Program exited");
        }

        private static void InsertRandomPallet()
        {
            Pallet pallet = GeneratorAS.CreatePallet();
            Console.WriteLine($"Pallet | Count:{pallet.count} | Good name: {pallet.good.name} | Good manufacturer: {pallet.good.manufacturer} |");
            client.insertPallet(pallet);
        }

        private static void InsertCustomPallet()
        {
            Console.WriteLine("Insert name of product");
            string pname = Console.ReadLine();
            Console.WriteLine("Insert manufacturer of product");
            string pman = Console.ReadLine();
            Console.WriteLine("Insert number of product items");
            string pcount = Console.ReadLine();
            client.insertPallet(new Pallet()
            {
                count = int.Parse(pcount),
                good = new Good()
                {
                    manufacturer = pman,
                    name = pname
                }
            });
        }

        private static void CreateTruck()
        {
            List<Good> goods = GeneratorAS.GenerateRandomNumberOfGoods();
            foreach (Good g in goods)
            {
                Pallet pallet = new Pallet()
                {
                    count = rnd.Next(10, 200),
                    good = g,
                };
                Console.WriteLine($"Pallet | Count:{pallet.count} | Good name: {pallet.good.name} | Good manufacturer: {pallet.good.manufacturer} |");
                client.insertPallet(pallet);
                Thread.Sleep(rnd.Next(3000, 5000));
            }
        }

        static void Main(string[] args)
        {
            client = new WarehouseWSClient();
            StartMenu();
        }
    }
}
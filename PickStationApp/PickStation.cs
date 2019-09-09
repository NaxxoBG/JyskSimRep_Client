using PickStationApp.ServiceReference1;
using System;
using System.Collections.Generic;

namespace PickStationApp
{
    class PickStation
    {
        private int pickUpStationID;
        private WarehouseWSClient client;
        private Random rnd;

        public PickStation(int stationId, WarehouseWSClient client)
        {
            pickUpStationID = stationId;
            this.client = client;
            rnd = new Random();
        }
        private void PrintMenu()
        {
            Console.WriteLine("1. Request random good");
            Console.WriteLine("2. Request custom good.");
            Console.WriteLine("3. Generate order");
            Console.WriteLine("4. Exit");
        }

        public void Start()
        {
            PrintMenu();
            string choice = Console.ReadLine();
            while (choice != "4")
            {
                switch (choice)
                {
                    case "1":
                        RequestRandomGood();
                        break;
                    case "2":
                        RequestCustomGood();
                        break;
                    case "3":
                        CreateOrder();
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

        private void RequestRandomGood()
        {
            Good good = GeneratorPS.GenerateGood();
            int count = rnd.Next(20, 200);
            Console.WriteLine($"Requested good | Count:{count} | Good name: {good.name} | Good manufacturer: {good.manufacturer} |");
            Pallet[] pallets = client.retrievePallets(good, count, pickUpStationID);
            FinishRequest(pallets, count);
        }

        private void RequestCustomGood()
        {
            Console.WriteLine("Insert name of product");
            string name = Console.ReadLine();
            Console.WriteLine("Insert manufacturer of product");
            string man = Console.ReadLine();
            Console.WriteLine("Insert number of product items");
            int count = 0;
            while (!int.TryParse(Console.ReadLine(), out count)) { }
            Pallet[] p = client.retrievePallets(new Good()
            {
                manufacturer = man,
                name = name
            }, count, pickUpStationID);
            FinishRequest(p, count);
        }

        private void CreateOrder()
        {
            List<Good> goods = GeneratorPS.GenerateRandomNumberOfGoods();
            foreach (Good g in goods)
            {
                int count = rnd.Next(20, 200);
                Console.WriteLine($"Requested good | Count:{count} | Good name: {g.name} | Good manufacturer: {g.manufacturer} |");
                Pallet[] p = client.retrievePallets(g, count, pickUpStationID);
                FinishRequest(p, count);
            }
        }

        private void InsertLeftOver(Good good, int c)
        {
            Console.WriteLine($"Leftover pallet | Name: {good.name} | Manufacturer: {good.manufacturer} | Count: {c} |");
            client.insertPallet(new Pallet()
            {
                good = good,
                count = c
            });
        }

        private void FinishRequest(Pallet[] pallets, int count)
        {
            if (pallets != null && pallets.Length > 0)
            {
                int totalCount = 0;
                foreach (Pallet p in pallets)
                {
                    Console.WriteLine($"Received pallet | Name: {p.good.name} | Manufacturer: {p.good.manufacturer} | Count: {p.count} |");
                    totalCount += p.count;
                }
                if (totalCount > count)
                {
                    InsertLeftOver(pallets[0].good, totalCount - count);
                }
            }
            else
            {
                Console.WriteLine("Good not found");
            }
        }

    }
}

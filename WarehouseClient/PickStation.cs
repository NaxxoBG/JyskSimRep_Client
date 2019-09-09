using System;
using System.Threading;
using WarehouseClient.ServiceReference1;

namespace WarehouseClient
{
    class PickStation
    {
        public int StationId { get; set; }
        public WarehouseWSClient client;
        private static Random rnd = new Random();

        public PickStation(int id, WarehouseWSClient client)
        {
            StationId = id;
            this.client = client;
        }

        public void ExecuteRandomOrders()
        {
            new Thread(() =>
            {
                while (true)
                {
                    Good generatedGood = GeneratorClient.GenerateGood();
                    int goodCount = rnd.Next(10, 80);
                    int received = 0;
                    Pallet[] result = client.retrievePallets(generatedGood, goodCount, StationId);

                    Console.WriteLine($"Requested good | Name: {generatedGood.name} | Manufacturer: {generatedGood.manufacturer} | Good count: {goodCount} |");

                    if (result != null && result.Length > 0)
                    {
                        foreach (Pallet p in result)
                        {
                            received += p.count;
                        }
                        if (received > goodCount)
                        {
                            Pallet leftOver = new Pallet()
                            {
                                count = received - goodCount,
                                good = generatedGood
                            };
                            Console.WriteLine($"Leftover pallet | Name: {generatedGood.name} | Manufacturer: {generatedGood.manufacturer} | Count: {leftOver.count} |");
                            InsertRemainingPallet(leftOver);

                        }
                        Console.WriteLine($"Number of received pallets : {result.Length}");
                        Console.WriteLine($"Pallets | Count: {result[0].count} | Good name: {result[0].good.name} | good manufacturer: {result[0].good.manufacturer} |");
                    }
                    else
                    {
                        Console.WriteLine("Good not found :(");
                    }
                    Thread.Sleep(rnd.Next(3000, 6000));
                }
            }).Start();
        }

        private void InsertRemainingPallet(Pallet pallet)
        {
            client.insertPallet(pallet);
        }
    }
}
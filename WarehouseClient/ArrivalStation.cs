using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WarehouseClient.ServiceReference1;

namespace WarehouseClient
{
    class ArrivalStation
    {
        private static Random rnd = new Random();

        private WarehouseWSClient client;

        public ArrivalStation(WarehouseWSClient client)
        {
            this.client = client;
        }

        public void StartArrivalStation()
        {
            while (true)
            {
                List<Good> goods = GeneratorClient.GenerateRandomNumberOfGoods();
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
                    Console.WriteLine("Pallet inserted!");
                }
            }
        }
    }
}
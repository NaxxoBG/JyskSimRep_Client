using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseClient.ServiceReference1;

namespace WarehouseClient
{
    class WarehouseMain
    {
        static void Main(string[] args)
        {
            WarehouseWSClient client = new WarehouseWSClient();

            PickStation pickStation = new PickStation(5, client);
            pickStation.ExecuteRandomOrders();

            PickStation pickStation2 = new PickStation(6, client);
            pickStation2.ExecuteRandomOrders();

            ArrivalStation arrivalStation = new ArrivalStation(client);
            arrivalStation.StartArrivalStation();
        }
    }
}
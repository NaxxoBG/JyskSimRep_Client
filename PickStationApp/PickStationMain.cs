using PickStationApp.ServiceReference1;

namespace PickStationApp
{
    class PickStationMain
    {
        static void Main(string[] args)
        {
            WarehouseWSClient client = new WarehouseWSClient();
            PickStation pickStation = new PickStation(100, client);
            pickStation.Start();
        }
    }
}

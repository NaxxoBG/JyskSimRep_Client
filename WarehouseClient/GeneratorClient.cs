using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using WarehouseClient.ServiceReference1;

namespace WarehouseClient
{
    public class GeneratorClient
    {
        private static readonly Good[] goods = {
            new Good () {manufacturer = "Hitachi", name = "55-Inch 4K Ultra HD Smart QLED TV"},
            new Good () {manufacturer = "Panasonic", name = "In-Ear Headphone"},
            new Good () {manufacturer = "Asus", name = "Gaming laptop"},
            new Good () {manufacturer = "Sony", name = "Sony Xperia XZs"},
            new Good () {manufacturer = "Philips", name = "Laptop Latitude E5450"},
            new Good () {manufacturer = "Siemens", name = "Siemens Q120"},
            new Good () {manufacturer = "Apple", name = "OEM Apple iPhone 7 Earpod Headphones"},
            new Good () {manufacturer = "Nestle", name = "Coffee-mate"},
            new Good () {manufacturer = "Procter & Gamble", name = "Invigorating mint, oral rinse"},
            new Good () {manufacturer = "PepsiCo", name = "Salted Chips"},
            new Good () {manufacturer = "Unilever", name = "shampoo"},
            new Good () {manufacturer = "Dell", name = "laptop H435Y"},
            new Good () {manufacturer = "Intel", name = "Core i3-7100"},
            new Good () {manufacturer = "LG Electronics", name = "LG G Flex 2"},
            new Good () {manufacturer = "Canon", name = "Digital slr camera"},
            new Good () {manufacturer = "Fujitsu", name="iX500 ScanSnap Document Scanner (PA03656-B305)"},
            new Good () {manufacturer = "Continentlal", name = "tires"},
            new Good () {manufacturer = "Cat", name = "Hooded Sweatshirt"},
            new Good () {manufacturer = "John Deere", name = "Folding Pocket Knife"},
            new Good () {manufacturer = "Huawei", name = "Huawei P8 Lite 16GB"},
            new Good () {manufacturer = "L'Oreal", name = "AXE Denim After Shave Lotion 50ml"},
            new Good () {manufacturer = "Fujifilm", name = "X100F digital camera"},
            new Good () {manufacturer = "Bosch", name = "Woodworking blade set"},
            new Good () {manufacturer = "Henkel", name = "Body Wash"},
            new Good () {manufacturer = "Adidas", name = "hoodie"},
            new Good () {manufacturer = "Nike", name = "Men's T-Shirt"},
            new Good () {manufacturer = "Puma", name = "sneakers"},
            new Good () {manufacturer = "Lyle & Scott", name = "jacket"},
            new Good () {manufacturer = "H&M", name = "shirt"},
            new Good () {manufacturer = "Lacoste", name = "jeans"},
            new Good () {manufacturer = "LC Waikiki", name = "vest"},
        };

        private static Random randomInt = new Random();

        public static Good GenerateGood()
        {
            return goods[randomInt.Next(goods.Count())];
        }

        public static List<Good> GenerateRandomNumberOfGoods()
        {
            List<Good> goodsInTruck = new List<Good>();
            for (int i = 0; i < randomInt.Next(10, 30); i++)
            {
                goodsInTruck.Add(GenerateGood());
            }
            return goodsInTruck;
        }

        public static Pallet CreatePallet()
        {
            return new Pallet()
            {
                good = GenerateGood(),
                count = randomInt.Next(1, 200),
                id = randomInt.Next(1, int.MaxValue)
            };
        }
    }
}
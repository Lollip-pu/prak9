using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Phone
    {
        private string brand;
        private int batteryLevel;
        public string Brand { get { return brand; } set { brand = value; } }
        public int BatteryLevel { get { return batteryLevel; } set {
                if (value >= 0 && value <=100)
                batteryLevel = value;
            else
                    Console.WriteLine("Заряд должен быть от 1 до 100");
            } }
        public Phone(string brand, int batteryLevel)
        {
            this.brand = brand;
            this.batteryLevel = batteryLevel;
        }
        public void UsePhone() {
            batteryLevel -= 10;
            if (batteryLevel < 0)
                batteryLevel = 0;
           Console.WriteLine($"Телефон {brand} , заряд {batteryLevel}");
        }

    }
    
    class Program
    {
        static void Main()
        {
            Phone phone = new Phone("Huawei", 57);
            phone.UsePhone();
            phone.BatteryLevel = -4;
            phone.UsePhone();
            Console.ReadLine();
        }
    }
}

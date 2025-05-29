using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modificatorydostypa;

namespace modificatorydostypa
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetMakeAndModel("toyota", "marktwo");
            car.Year = 2006;

            ElectricCar electricCar = new ElectricCar();
            electricCar.SetMakeAndModel("tesla", "modelx");
            electricCar.Year = 2025;
            electricCar.SetBatteryCapacity(100);

            car.DisplayInfo();
            electricCar.DisplayInfo();

            Console.ReadKey();
        }
    }
    public class Car
    {
        private string make;
        private string model;
        public int Year { get; set; }
        internal void SetMakeAndModel(string make, string model) { 
            this.make = make;
            this.model = model;
        }
        protected virtual void DisplayInfo() {
            Console.WriteLine($"{make}, {model}, {Year}");
        }
    }
    public class ElectricCar : Car {
        private double batteryCapacity;
        public void SetBatteryCapacity(double batteryCapacity) {
            this.batteryCapacity = batteryCapacity;
        }
        protected override void DisplayInfo() { 
            base.DisplayInfo();
            Console.WriteLine("{batteryCapacity}");
        }
    }
}
/*
namespace modify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetMakeAndModel("toyota", "marktwo");
            car.Year = 2006;

            ElectricCar electricCar = new ElectricCar();
            electricCar.SetMakeAndModel("tesla", "modelx");
            electricCar.Year = 2025;
            electricCar.SetBatteryCapacity(100);

            car.DisplayInfo();
            electricCar.DisplayInfo();

            Console.ReadKey();
        }
    }
}
*/

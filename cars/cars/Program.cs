using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car();
            myCar1.AddCars("Mitsubishi", "Shogun", 40000);

            Car myCar2 = new Car();
            myCar2.AddCars("Toyota", "Landcruiser V8", 50000);

            Car myCar3 = new Car();
            myCar3.AddCars("Volvo", "XC60", 38000);

            Console.WriteLine("Total number of 4x4s in stock: {0}", Car.numberofCars);
            Console.WriteLine();

            Console.WriteLine("Car Details");
            Console.WriteLine("Name & Model: {0} {1}, Price: £{2:N0}", myCar1.name, myCar1.model, myCar1.price);
            Console.WriteLine("Name & Model: {0} {1}, Price: £{2:N0}", myCar2.name, myCar2.model, myCar2.price);
            Console.WriteLine("Name & Model: {0} {1}, Price: £{2:N0}", myCar3.name, myCar3.model, myCar3.price);
            Console.Read();
        }
    }

    class Car
    {
        public string name;
        public string model;
        public int price;
        public bool sold;

        public static int numberofCars = 0;

        public void AddCars(string name, string model, int price)
        {
            this.name = name;
            this.model = model;
            this.price = price;

            Car.numberofCars++;
        }
    }
}

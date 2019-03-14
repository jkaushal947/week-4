using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carlist = new List<Car>();
       
            //Car obj1 = new Car("Volkswagen", "Touareg", 47000);
           
            //carlist.Add(obj1);
             
            Car myCar1 = new Car("Mitsubishi", "Shogun", 40000);
            Car myCar2 = new Car("Nissan", "Qashqai", 18000);
            Car myCar3 = new Car("Volvo", "XC60", 38000);
            Car myCar4 = new Car("Peugeot", "5008", 25000);
            Car myCar5 = new Car("Audi", "Q7", 52000);
            Car myCar6 = new Car("Subaru", "Forester", 25000);
            Car myCar7 = new Car("Volkswagen", "Touareg", 47000);
            Car myCar8 = new Car("Ford", "Ecosport", 17000);
            Car myCar9 = new Car("Renault", "Captur", 14000);
            Car myCar10 = new Car("Volkswagen", "Touareg", 47000);

            carlist.Add(myCar1);
            carlist.Add(myCar2);
            carlist.Add(myCar3);
            carlist.Add(myCar4);
            carlist.Add(myCar5);
            carlist.Add(myCar6);
            carlist.Add(myCar7);
            carlist.Add(myCar8);
            carlist.Add(myCar9);
            carlist.Add(myCar10);

            Console.WriteLine("Total number of 4x4s in stock: {0}", Car.numberofCars);
            Console.WriteLine();

            Console.WriteLine("Car Details");
            Car.display(carlist);
            Console.Read();
        }

    }

    class Car
    {
        public string name;
        public string model;
        public int price;
        //public bool sold;

        public static int numberofCars = 0;

        public Car(string name, string model, int price)
        {
            this.name = name;
            this.model = model;
            this.price = price;
            //this.sold = false;
            Car.numberofCars++;
        }

        public static void display(List<Car> list)
        {
            for(int i=0; i<list.Count; i++)
            {
                Console.WriteLine("Name & Model: {0} {1}, Price: £{2:N0}", list[i].name, list[i].model, list[i].price);

            }
        }

        //public static void search(List<Car> list)
        //{
        //    Console.WriteLine("Search for the name of a car");
        //    string searchmake = Console.ReadLine();
        //    bool caravailable = list.Contains

        //    if (caravailable == true)
        //    {
        //        Console.WriteLine(searchmake + " is on the list. \n");
        //    }
        //}

        public static void delete(List<Car> list)
        {
            string make = "";
            Console.WriteLine("Enter the name of the car you wish to remove");
            make = Console.ReadLine();

            for(int i = 0; i < list.Count; i++)
            {
                if (make == list[i].name)
                {
                    list.Remove(list[i]);
                    Car.numberofCars--;
                }
                else
                {
                    Console.WriteLine("Car not found on list. Try again.");
                }
            }
        }


    }


}

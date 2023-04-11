
using System;
using System.Collections.Generic;
using System.Linq;
namespace CarStore
{
    public class Car
    {
        public Car()
        {
            Brand = "nothing yet";
            Model = "nothing yet";
            Price = 0.00M;
        }
        public Car(string brand, string model, decimal price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public string Summary()
        {
            return $"Brand: {Brand} Model: {Model} Price: ${Price}";
        }
    }

    public class Store
    {
        public List<Car> Cars { get; set; }
        public List<Car> ShoppingList { get; set; }

        public Store()
        {
            //Initialize
            Cars = new List<Car>();
            ShoppingList = new List<Car>();
        }

        public decimal Checkout()
        {
            decimal totalCost = 0.00M;
            foreach (var c in ShoppingList)
            {
                totalCost += c.Price;
            }
            return totalCost;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {

            var store = new Store();

            System.Console.WriteLine("Welcome to the car store. First you must create some car inventory. Then you may add some cars to the shopping cart. Finally you may checkout which will give you a total value of the shopping cart.");

            int action = chooseAction();

            while (action != 0)
            {
                switch (action)
                {
                    case 1:
                        System.Console.WriteLine("You chose to add a new car to the inventory");

                        String carBrand = "";
                        String carModel = "";
                        Decimal carPrice = 0;

                        System.Console.WriteLine("What is the car brand? ford, kia etc.");
                        carBrand = Console.ReadLine();

                        System.Console.WriteLine("What is the car model? focus, niro etc.");
                        carModel = Console.ReadLine();

                        System.Console.WriteLine("What is the car price?");
                        carPrice = int.Parse(Console.ReadLine());

                        var newCar = new Car(carBrand, carModel, carPrice);
                        store.Cars.Add(newCar);

                        printInvemtory(store);
                        break;
                }


                action = chooseAction();
            }

            static void printInvemtory(Store s)
            {
                foreach (var c in s.Cars)
                {
                    System.Console.WriteLine("Car: " + c.Summary());
                }
            }

            static int chooseAction()
            {
                int choice = 0;
                System.Console.WriteLine($"Choose an action (0) to quit (1) to add a new car to inventory (2) add car to cart (3) checkout");

                choice = int.Parse(Console.ReadLine());
                return choice;
            }

            var mustang = new Car("Ford", "Mustang", 25000);
            var niro = new Car("Kia", "Niro", 12000);



            store.ShoppingList.Add(mustang);
            store.ShoppingList.Add(niro);

            decimal total = store.Checkout();
            System.Console.WriteLine($"Store value is {total}");
        }


    }
}

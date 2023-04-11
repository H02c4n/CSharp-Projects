
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
            Modal = "nothing yet";
            Price = 0.00M;
        }
        public Car(string brand, string modal, decimal price)
        {
            Brand = brand;
            Modal = modal;
            Price = price;
        }
        public string Brand { get; set; }
        public string Modal { get; set; }
        public decimal Price { get; set; }
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
            var mustang = new Car("Ford", "Mustang", 25000);
            var niro = new Car("Kia", "Niro", 12000);

            var store = new Store();

            store.ShoppingList.Add(mustang);
            store.ShoppingList.Add(niro);

            System.Console.WriteLine(store.Checkout());
        }
    }
}

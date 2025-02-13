using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bill: ");
            FastFood burger = new FastFood("burger" , 20.97M);
            burger.DisplayDetails();

            Beverages soda = new Beverages("Cola", 5);
            soda.DisplayDetails();

            Dessert cake = new Dessert("Cake", 20.6M);
            cake.DisplayDetails();

            SeaFood fish = new SeaFood("Fish ", 25.25M);
            fish.DisplayDetails();
            Pizza pizza = new Pizza("Pizza", 30.30M, 8);
            pizza.DisplayDetails();

            Console.WriteLine("Employees: ");
            Console.Write("Chef: ");
            Chef chef = new Chef("Ali", 150);
            chef.DisplayDetails();

            Console.Write("Waiter: ");
            Waiter waiter = new Waiter("Subhan", 10.50M);
            waiter.DisplayDetails();

            Console.Write("Manager: ");
            Manager manager = new Manager("HAMZA", 500.30M);
            manager.DisplayDetails();
            //  Github lab 
            Console.WriteLine("enter the number 1");
            int number 1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number 2");
            int number 2 = Convert.ToInt32(Console.ReadLine());
            
            
        }
    }
}

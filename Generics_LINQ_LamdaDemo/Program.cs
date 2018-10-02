using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics_LINQ_LamdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generics Demo Begin
            //var intArray = new MyArray<int>();
            //intArray.Add(20);
            //var stringArray = new MyArray<string>();
            //stringArray.Add("Aparna");
            //var employeeArray = new MyArray<Employee>();
            //employeeArray.Add(new Employee { ID = 1, Name = "Aparna" });
            //Generics Demo done

            var customers = new List<Customer>
            {
            new Customer{CustomerID=1, Name="Fred"},
            new Customer{CustomerID=2, Name="Meyer"}
        };

            var orders = new List<Order>
            {
                new Order{OrderID=1, CustomerID=1, Cost=155.23M},
                new Order{OrderID=2, CustomerID=2, Cost=234.54M},
                new Order{OrderID=3, CustomerID=1, Cost=500.09M}
            };

            // var found=orders.Where(o => o.CustomerID == 1);
            var found = orders.Where(o => o.CustomerID == 1 && o.Cost > 300);
            //var found = from o in orders
              //          where o.CustomerID == 1
                //        select o;

            foreach(var result in found)
            {
                Console.WriteLine($"OrderID:{result.OrderID}, CustomerID: {result.CustomerID}, cost: {result.Cost}");
            }
        }


        class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }
}

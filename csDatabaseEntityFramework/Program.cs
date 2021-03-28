using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace csDatabaseEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer()
                {
                    Name = "Jakub",
                    Address = "Karvina"
                },
                new Customer()
                {
                    Name = "Petr",
                    Address = null
                }
            };

            string connectionstring = "Data Source=mydb.db";


            MyDbContext ctx = new MyDbContext();


            Customer c = ctx.Customers.First(x => x.Id == 1);
            c.Name = c.Name.ToUpper();
            ctx.SaveChanges();

            //foreach (var c in ctx.Customers.Include("Orders"))
            //{
            //    Console.WriteLine(c.Id + " " + c.Name + " " + c.Address);

            //    foreach (var o in c.Orders)
            //    {
            //        Console.WriteLine(o?.Product + " " + o?.Price);
            //    }
            //}

            //ctx.Orders.Add(new Order() {CustomerId = 1, Price = 200, Product = "Aha nevim bro"});
            //ctx.SaveChanges();

            //foreach (var c in ctx.Customers.Where(x => x.Name == "Jakub"))
            //{
            //    Console.WriteLine(c.Id + " " + c.Name + " " + c.Address);
            //}

            //foreach (var c in customers)
            //{
            //    ctx.Customers.Add(c);
            //}

            //ctx.SaveChanges();







        }
    }
}

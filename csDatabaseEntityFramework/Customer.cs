using System;
using System.Collections.Generic;
using System.Text;

namespace csDatabaseEntityFramework
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public List<Order> Orders { get; set; }
    }
}

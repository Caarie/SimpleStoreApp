using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp.Model.Models
{
    public class ProductType
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }

        public string StoreType { get; set; }
        public double Price { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp.Model.Models
{
    public class Store
    {
        public int ID
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Address
        {
            get; set;
        }

        public string Type { get; set; }
    }
}

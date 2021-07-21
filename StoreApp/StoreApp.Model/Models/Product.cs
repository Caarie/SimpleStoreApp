using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp.Model.Models
{
    public class Product
    {

        public int ID { get; set; }
        public int ProductTypeID { get; set; }
        public string Barcode { get; set; }
        public DateTime ExpiryDate { get; set; }

        public int StockID { get; set; }

    }
}

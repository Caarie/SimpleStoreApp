using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp.Model.Models
{
    public class Stock
    {

        public int ID { get; set; }
        public int ProductTypeID { get; set; }

        public int StoreID { get; set; }
        public int ShelfID { get; set; }

        public int EmployeeID { get; set; }

        public DateTime AcquisitionDate { get; set; }
        public int Amount { get; set; }


    }
}

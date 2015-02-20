using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BMK.Models
{
    public class Product
    {
        public string SKU
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public decimal Price
        {
            get;
            set;
        }

        public int Images
        {
            get;
            set;
        }

        public int QtyInStock
        {
            get;
            set;
        }
    }
}

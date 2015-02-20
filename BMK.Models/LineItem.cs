using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BMK.Models
{
    public class LineItem
    {
        public int Id
        {
            get;
            set;
        }

        public string SKU
        {
            get;
            set;
        }

        public int Description
        {
            get;
            set;
        }

        public List<string> Discounts
        {
            get;
            set;
        }

        public decimal LineTotal
        {
            get;
            set;
        }

        public Order Order
        {
            get;
            set;
        }

        public int Qty
        {
            get;
            set;
        }
    }
}

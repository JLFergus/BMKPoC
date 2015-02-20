using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BMK.Models
{
    public class Order
    {
        public int Id
        {
            get;
            set;
        }

        public string OrderNumber
        {
            get;
            set;
        }

        public string Details
        {
            get;
            set;
        }

        public List<LineItem> LineItems
        {
            get;
            set;
        }

        public decimal Subtotal
        {
            get;
            set;
        }

        public List<string> Discounts
        {
            get;
            set;
        }

        public decimal Tax
        {
            get;
            set;
        }

        public decimal OrderTotal
        {
            get;
            set;
        }

        public User User
        {
            get;
            set;
        }
    }
}

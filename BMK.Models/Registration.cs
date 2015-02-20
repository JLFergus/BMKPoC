using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BMK.Models
{
    public class Registration
    {
        public User User
        {
            get;
            set;
        }

        public Product Product
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }

        public string Comment
        {
            get;
            set;
        }
    }
}

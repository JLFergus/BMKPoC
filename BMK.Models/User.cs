using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations.Resources;
using System.ComponentModel.DataAnnotations;

namespace BMK.Models
{
    public class User
    {
        public int Id
        {
            get;
            set;
        }
        
        public string FirstName
        {
            get;
            set;
        }
        
        public string LastName
        {
            get;
            set;
        }
        
        public string AddressLine1
        {
            get;
            set;
        }

        public string AddressLine2
        {
            get;
            set;
        }

        public string City
        {
            get;
            set;
        }

        public string Region
        {
            get;
            set;
        }

        public string PostalCode
        {
            get;
            set;
        }

        public string Phone
        {
            get;
            set;
        }

        public CustomerType Type
        {
            get;
            set;
        }

        public List<Order> Orders
        {
            get;
            set;
        }

        public List<Registration> RegisteredKnives
        {
            get;
            set;
        }
    }
}

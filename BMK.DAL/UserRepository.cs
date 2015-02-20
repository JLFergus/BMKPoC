using BMK.Models;
using System;
using System.Collections.Generic;

namespace BMK.DAL
{
    public class UserRepository : IUserRepository
    {
        public User SaveUser(User user)
        {
            if (user.Id == null)
                user.Id = 0;

            return user;
        }

        public User SaveUser(string firstName, string lastName, string addressLine1, string addressLine2, string city, string region, string postalCode, string phone, CustomerType type)
        {
            return SaveUser(new User
            {
                FirstName = firstName,
                LastName = lastName,
                AddressLine1 = addressLine1,
                AddressLine2 = addressLine2,
                City = city,
                Region = region,
                PostalCode = postalCode,
                Phone = phone,
                Type = type,
                Orders = new List<Order>(),
                RegisteredKnives = new List<Registration>()
            });
        }

        public User GetUser(int userId)
        {
            return new User
            {
                Id = userId,
                FirstName = "Sherlock",
                LastName = "Holmes",
                AddressLine1 = "221B Baker St",
                City = "London",
                Region = "Oregon",
                PostalCode = "97005",
                Phone = "503-384-2211",
                Type = CustomerType.Consumer,
                Orders = new List<Order>(),
                RegisteredKnives = new List<Registration>()
            };
        }

        public Registration RegisterProduct(User user, Product product)
        {
            return new Registration 
            { 
                User = user, 
                Product = product ,
                Date = DateTime.Now.Date,
                Comment = "Registered!"
            };
        }

        public Registration RegisterProduct(int userId, string productSKU)
        {
            return new Registration
            {
                User = new User { Id = userId },
                Product = new Product { SKU = productSKU },
                Date = DateTime.Now.Date,
                Comment = "Registered!!"
            };
        }
    }
}
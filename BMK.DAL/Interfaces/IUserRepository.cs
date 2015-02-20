using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMK.Models;

namespace BMK.DAL
{
    public interface IUserRepository
    {
        User SaveUser(User user);
        User SaveUser(string FirstName, string LastName, string AddressLine1, string AddressLine2, string City,
            string Region, string PostalCode, string Phone, CustomerType type);
        
        User GetUser(int userId);
        Registration RegisterProduct(int userId, string productSKU);
        Registration RegisterProduct(User user, Product product);
    }
}

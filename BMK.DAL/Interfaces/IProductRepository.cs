using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMK.Models;

namespace BMK.DAL
{
    public interface IProductRepository
    {
        Product SaveProduct(Product product);
        Product SaveProduct(string sku, string name, string description, decimal price, int qtyInStock = 0);

        Product GetProduct(int productId);
    }
}

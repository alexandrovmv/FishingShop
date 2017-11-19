using DAL.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingShop.Models
{
    public interface IContext
    {
        IEnumerable<Product> GetGoods();
        IEnumerable<Category> GetCategories();
       
    }
}

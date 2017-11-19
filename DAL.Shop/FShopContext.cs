using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Shop
{
    public class FShopContext : DbContext
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public List<Photo> Photos { get; set; }
        public List<Producer> Producers { get; set; }
        public FShopContext() : base("name=FishingShopDb")
        {
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Shop
{
    public class Product
    {
        [Key]
        public int PoductId { get; set; }
        [MaxLength(100), Required]   
        public string  Name { get; set; }
        public int Quantity { get; set; }       
        public double Price { get; set; }
        public virtual int ProducerId { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual List<Photo> Photos { get; set; }
    }
}

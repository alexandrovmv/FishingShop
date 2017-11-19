using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Shop
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [MaxLength(100),Required]
        public string Name { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Shop
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }
        public int ProductId { get; set; }
        public string Path { get; set; }
    }
}

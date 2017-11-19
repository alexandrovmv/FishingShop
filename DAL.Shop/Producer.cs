using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Shop
{
    public class Producer
    {
        [Key]
        public int PoducerId { get; set; }
        [Required]
        public string Name { get; set; }

    }
}

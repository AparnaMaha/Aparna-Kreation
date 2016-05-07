using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKreations
{
    public class Product
    {
        [Key]
        public string Catogery { get; set; }
        [StringLengthAttribute(15,ErrorMessage ="Product Name Should be 15 Characters in length")]
        public string ProductName { get; set; }
        public double Amount { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

    }
}

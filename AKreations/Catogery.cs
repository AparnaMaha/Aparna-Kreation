using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKreations
{
    public enum BrandType
    {
        MichaelKors, 
        LouieVouton,
        Coach,
        AparnaKreations
    }
    public class Catogery
    {
        public string SubCatogery { get; set; }
        public string Product { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public BrandType TypeofBrand { get; set; }
    }
}

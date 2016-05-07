using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKreations
{
    public static class Store
    {
        #region
        public static ProductModel db = new ProductModel();
        #endregion
        public static Product AddProduct(string prodCatogory, string prodItemName, double prodAmount, int prodItemQty, string prodDesc)
        {
            var product = new Product
            {
                Catogery = prodCatogory,
                ProductName = prodItemName,
                Amount = prodAmount,
                Quantity = prodItemQty,
                Description = prodDesc
            };
            db.products.Add(product);
            db.SaveChanges();
            return product;
        }

    }
}

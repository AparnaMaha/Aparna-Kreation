using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKreations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++++++++*************** Welcome to Aparna Kreations ***************+++++++++");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("What is the Category for this Item? ");
            var prodCatogory = Console.ReadLine();
            Console.Write("What is the name of this Item? ");
            var prodItemName = Console.ReadLine();
            Console.Write("Describe this item: ");
            var prodDesc = Console.ReadLine();
            var product1 = Store.AddProduct(prodCatogory, prodItemName, 200, 2, prodDesc);
            Console.WriteLine("Item Category Name: {0}, Item Name: {1}, Item Amount: {2:C}, Item Quantity: {3}, Describition: {4} ", prodCatogory, prodItemName, product1.Amount, product1.Quantity, prodDesc);

        }
    }
}

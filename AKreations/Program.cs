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
            Console.WriteLine("Please enter your name : ");
            var Intro = Console.ReadLine();
            Console.WriteLine("+++++++++*************** Welcome to Aparna Kreations ***************+++++++++");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Hello " + Intro + " ,welcome please select from these options...");
            string ProdOption;
            do
            {

                Console.WriteLine("1. Add a new product");
                Console.WriteLine("2. Sell a product");
                Console.WriteLine("3. Delete a product");
                Console.WriteLine("4. Print product");
                Console.WriteLine("0. Exit");
                ProdOption = Console.ReadLine();
                switch (ProdOption)
                {
                    case "1":
                        Console.Write("What is the Category for this Item? ");
                        var prodCatogory = Console.ReadLine();
                        Console.Write("What is the name of this Item? ");
                        var prodItemName = Console.ReadLine();
                        Console.Write("Describe this item: ");
                        var prodDesc = Console.ReadLine();
                        var product1 = Store.AddProduct(prodCatogory, prodItemName, 200, 2, prodDesc);
                        Console.WriteLine("Item Category Name: {0}, Item Name: {1}, Item Amount: {2:C}, Item Quantity: {3}, Describition: {4} ", prodCatogory, prodItemName, product1.Amount, product1.Quantity, prodDesc);
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        PrintProducts();
                        break;

                    case "0":
                        Console.WriteLine("Good Bye!");
                        return;

                    default:
                        break;
                }
            } while (ProdOption != "0");
        }

        static void PrintProducts()
        {
            foreach (var addProducts in Store.products)
            {
                Console.WriteLine("Product Catogory: {0}, Product Item Name: {1}", addProducts.Catogery, addProducts.ProductName);
            }
        }
    }
}

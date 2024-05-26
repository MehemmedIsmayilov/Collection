using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class Invertory
    {
        public Dictionary<string, int> Products { get; set; }

        public Invertory()
        {

            Products = new Dictionary<string, int>();
        }


        public void AddProduct(string productName, int quantity)
        {
            if (Products.ContainsKey(productName))
            {

                Products[productName] += quantity;
            }
            else
            {

                Products[productName] = quantity;
            }
        }


        public void RemoveProduct(string productName)
        {
            if (Products.ContainsKey(productName))
            {
                Products.Remove(productName);
            }
            else
            {
                Console.WriteLine($"{productName} bu adda mehsul yoxdur");
            }
        }


        public void UpdateQuantity(string productName, int quantity)
        {
            if (Products.ContainsKey(productName))
            {
                Products[productName] = quantity;
            }
            else
            {
                Console.WriteLine($"{productName} bu adda mehsul yoxdur");
            }
        }


        public int GetQuantityByProduct(string productName)
        {
            if (Products.ContainsKey(productName))
            {
                return Products[productName];
            }
            else
            {
                Console.WriteLine($"{productName} bu adda mehsul yoxdur");
                return 0;
            }
        }
    }
}

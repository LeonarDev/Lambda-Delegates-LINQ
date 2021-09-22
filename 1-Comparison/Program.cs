using System;
using System.Collections.Generic;
using _1_Comparison.Entities;

namespace _1_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // INLINE LAMBDA EXPRESSION
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            //       INLINE LAMBDA EXPRESSION
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            //       LAMBDA EXPRESSION TO DELEGATE VARIABLE
            // Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            // list.Sort(comp);

            //       METHOD REFERENCE TO DELEGATE VARIABLE
            // Comparison<Product> comp = CompareProducts;
            // list.Sort(comp);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}

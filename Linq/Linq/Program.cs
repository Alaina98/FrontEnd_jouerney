using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> productList = new Dictionary<string, int>();

            productList.Add("Hard Disk", 1280);
            productList.Add("Printer", 3000);
            productList.Add("Keyboard", 3500);
         
            //Method 1
            var search = from x in productList
                         where x.Key.Contains("Disk")
                         select x;
            //Method 2
            //var search = productList.Where(p => p.Key.Contains("Disk"));

            foreach (var result in search)
            {
                Console.WriteLine("Product Name: {0}, Price: {1}", result.Key, result.Value);
            }

            Console.ReadKey();
        }
    }
    }

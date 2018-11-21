using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckingFarm
{
   public class Program
    {
        static void Main(string[] args)
        {
            Product milk = new Product() { ProductName = "milk", ProductWeight = 10};
            Product cheese = new Product() { ProductName = "cheese", ProductWeight = 20 };
            Product meat = new Product() { ProductName = "meat", ProductWeight = 30 };
            
            Console.ReadLine();

        }
    }
}

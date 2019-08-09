using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default;

            var beer = new Beer();
            beer.Attach(new Pub("Guinnes Sky") { MaxBeerPrice = 3 });
            beer.Attach(new Pub("Cantuccio") { MaxBeerPrice = 2.5 });

            beer.Price = 2;
            beer.Price = 2.5;
            beer.Price = 3;

            Console.ReadKey();
            Console.ReadKey();
        }
    }
}

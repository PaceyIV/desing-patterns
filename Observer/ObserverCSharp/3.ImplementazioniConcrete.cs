using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    [DebuggerDisplay("Beer: {Price} €")]
    class Beer : Subject
    {
        private double price;

        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    Notify();

                    Console.WriteLine(String.Empty);
                }
            }
        }

    }

    [DebuggerDisplay("{Name}")]
    class Pub : IObserver
    {
        public string Name { get; }
        public double MaxBeerPrice { get; set; }

        public Pub(string name)
        {
            Name = name;
        }

        public void Update(ISubject subject)
        {
            var beer = subject as Beer;
            if (beer != null)
            {
                Console.WriteLine($"Notified {Name}: beer price changed to {(subject as Beer).Price.ToString("C2")}");
                if (beer.Price < MaxBeerPrice)
                    Console.WriteLine($"{Name} buys more beer!");
            }
        }
    }
}

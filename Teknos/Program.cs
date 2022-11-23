using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salad salad = new Salad();
            Crab crab = new Crab();
            Food[] foods = { salad, crab };
            Turtle Tihi = new Turtle();
            Tihi.Egyenlo();
            Console.WriteLine("A jóllakottsági szint: " + Tihi.FedLevel);
            Console.WriteLine("A boldogsági szint: " + Tihi.Happiness);

            foreach (Food food in foods)
            {
                Console.WriteLine("\nTápérték: " + food.Value());
            }

            Tihi.Eat(salad.Value(), crab.Value());

            Console.WriteLine("\nA jóllakottsági szint: " + Tihi.FedLevel);
            Console.WriteLine("A boldogsági szint: " + Tihi.Happiness);
        }
    }
}

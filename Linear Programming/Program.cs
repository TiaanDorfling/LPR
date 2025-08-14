using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu(); 
            Console.Read();
        }

        Enum menu
        {
            Calculate,
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Welcome to Linear Pramming Calculator\n\n");
            foreach (var var in menu.GetValues(typeof(Enum)))
            {
                Console.WriteLine($"{var.ToString()}");
            }
        }

    }
}

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

        enum menu
        {
            Calculate,
            Exit
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Welcome to Linear Pramming Calculator\n");
            foreach (var var in Enum.GetValues(typeof(menu)))
            {
                Console.WriteLine($"{(int)var + 1}. {var.ToString()}");
            }
            GetMenuInput();
        }

        static void GetMenuInput()
        {
            Console.Write("\nEnter your option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Time to Calculate!");
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input. Try again.");
                    Console.Clear();
                    DisplayMenu();
                    break;
            }
        }

    }
}

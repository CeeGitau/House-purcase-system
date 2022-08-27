// See https://aka.ms/new-console-template for more information
using System;

namespace houseSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            int house, garage;

            Console.WriteLine("Enter the type of house you want to purchase");
            Console.WriteLine("1. Single Family($50, 000)\n2. Townhouse($40, 000)\n3. Condominium($15, 000)\n4.Exit");

            Console.Write("Your choice? ");
            house = Convert.ToInt32(Console.ReadLine());

            if (house != 4)
            {
                Console.Write("Does the house have an indoor garage (1=Yes/0=No)? ");
                garage = Convert.ToInt32(Console.ReadLine());

                switch (house)
                {
                    case 1:
                        Console.WriteLine("Desired House Type: Single Family");
                        if (garage == 1)
                        {
                            Console.WriteLine("Has indoor garage? Yes");
                            Console.WriteLine("Total cost: $55,000");
                        }
                        else if (garage == 0)
                        {
                            Console.WriteLine("Has indoor garage? No");
                            Console.WriteLine("Total cost: $50,000");
                        }
                        else
                        {
                            Console.WriteLine("Has indoor garage? No");
                            Console.WriteLine("Total cost: $50, 000");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Desired House Type: Townhouse");
                        if (garage == 1)
                        {
                            Console.WriteLine("Has indoor garage? Yes");
                            Console.WriteLine("Total cost: $45,000");
                        }
                        else if (garage == 0)
                        {
                            Console.WriteLine("Has indoor garage? No");
                            Console.WriteLine("Total cost: $40,000");
                        }
                        else
                        {
                            Console.WriteLine("Has indoor garage? No");
                            Console.WriteLine("Total cost: $40, 000");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Desired House Type: Condominium");
                        if (garage == 1)
                        {
                            Console.WriteLine("Has indoor garage? Yes");
                            Console.WriteLine("Total cost: $20,000");
                        }
                        else if (garage == 0)
                        {
                            Console.WriteLine("Has indoor garage? No");
                            Console.WriteLine("Total cost: $15,000");
                        }
                        else
                        {
                            Console.WriteLine("Has indoor garage? No");
                            Console.WriteLine("Total cost: $15, 000");
                        }
                        break;
                    default:
                        Console.WriteLine("Desired House Type: Unknown");
                        if (garage == 1)
                        {
                            Console.WriteLine("Has indoor garage? No");
                            Console.WriteLine("Total cost: 0");
                        }
                        else if (garage == 0)
                        {
                            Console.WriteLine("Has indoor garage? No");
                            Console.WriteLine("Total cost: 0");
                        }
                        else
                        {
                            Console.WriteLine("Has indoor garage? No");
                            Console.WriteLine("Total cost: 0");
                        }
                        break;
                }
            }
            else if (house == 4)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("You have entered an invalid input. Try again");
            }
        }
    }
}

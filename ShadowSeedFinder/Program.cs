using System;

namespace ShadowSeedFinder
{
    class Program
    {   
        static void Main(string[] args)
        {
           Console.Title = "Shadow Seed Finder";
           Function();
           
        }

        static void Function()
        {

            Console.WriteLine("Enter seed:");
            string input = Console.ReadLine();
            try
            {
                long seed = long.Parse(input);
                long test = -7379792620528906219;
                long shadow = test - seed;
                Console.WriteLine("The seed you entered was " + seed);
                Console.WriteLine("The approximate shadow seed is: " + shadow);
                Console.WriteLine("Do you want to enter another seed? [Y/N]");
                string response = Console.ReadLine();

                if (response.Contains("Y"))
                {
                    Console.Clear();
                    Main(null);

                }
                else if (response.Contains("N"))
                {   
                    Console.Clear();
                    Console.Write("Press any key to exit.");
                    Console.ReadKey();
                } 
                else {

                    Console.Clear();
                    Console.Write("Press any key to exit.");
                    Console.ReadKey();
                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse \"{input}\".");
                Console.ReadKey();
                Console.Clear();
                Main(null);
            }

        }
    }
}

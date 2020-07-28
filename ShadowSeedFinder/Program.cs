using System;

namespace ShadowSeedFinder
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Function();
           
        }

        static void Function()
        {

            Console.WriteLine("Enter the seed to find the shadow of:");
            string input = Console.ReadLine();
            try
            {
                long seed = long.Parse(input);
                long test = -7379792620528906219;
                long shadow = test - seed;
                Console.WriteLine("This is a test function. The seed you entered was  " + seed);
                Console.WriteLine("The approximate shadow seed is: " + shadow);
                Console.WriteLine("Do you want to enter another seed? [Yes/No]");
                string response = Console.ReadLine();

                if (response.Contains("y"))
                {

                    Main(null);

                }
                else
                {

                    Console.Write("Goodbye....");

                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}' try again with a proper seed next time");
            }

        }
    }
}

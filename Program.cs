using System;

namespace CoughOrSneeze
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Did you cough or sneeze");
            string action = (Console.ReadLine());

            Console.WriteLine("How many times was it done ");
            int number = int.Parse(Console.ReadLine());

            try
            {
                if (action == "Cough ")
                {
                    Console.WriteLine("Bless you ");

                    int i = 1;
                    do
                    {
                        Console.WriteLine("Bless you ");
                        i++;
                    }

                    while (i < number);
                }

                else
                {
                    Console.WriteLine("Excuse you");

                    int i = 1;
                    do
                    {
                        Console.WriteLine("Excuse you ");
                        i++;
                    }

                    while (i < number);
                }
            }

            catch
            {
                Console.WriteLine("Error");
            }
               }

                
            

        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Jensen Charles

namespace FindTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int secret = rand.Next(1, 1001);
            int count = 0;

            while (true)
            {
                Console.WriteLine($"Pick a number between 1 and 1000: ");
                string sNumber = Console.ReadLine();

                int.TryParse(sNumber, out int number);

                if (number == secret)
                {
                    count++;
                    break;
                }
                else if (number > secret)
                {
                    Console.WriteLine($"Too big. Try again");
                    count++;
                }
                else if (number < secret)
                {
                    Console.WriteLine($"Too small. Try again");
                    count++;
                }
                
            }
            Console.WriteLine($"That's correct! You found the number in {count} tries!");

        }

        
    }
}

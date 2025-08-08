using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity29
{
    internal class Program
    {
        private static int start;
        private static int end;

        static void Main(string[] args)
        {
            // Input collection and validation
            while (true)
            {
                Console.Write("Enter the start value: ");
                start = int.Parse(Console.ReadLine());

                Console.Write("Enter the end value: ");
                end = int.Parse(Console.ReadLine());

                if (start < end)
                {
                    break; // Valid range, exit the loop
                }
                else
                {
                    Console.WriteLine("Error: Start value must be less than end value. Please try again.");
                }
            }

            Console.WriteLine($"Prime numbers between {start} and {end}:");

            // Loop through each number in the range
            for (int number = start; number <= end; number++)
            {
                if (number > 1) // Check if number is greater than 1
                {
                    bool isPrime = true;

                    // Check for factors
                    for (int factor = 2; factor * factor <= number; factor++)
                    {
                        if (number % factor == 0) // If divisible, not prime
                        {
                            isPrime = false;
                            break; // No need to check further
                        }
                    }
                    // If prime, print the number
                    if (isPrime)
                    {
                        Console.Write(number + " ");
                    }
                }
            }

            Console.WriteLine(); // New line after listing primes
        }
    }
}




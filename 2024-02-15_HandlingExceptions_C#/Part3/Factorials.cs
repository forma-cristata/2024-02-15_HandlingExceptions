using System;

namespace Part3
{
    public class Factorials
    {
        public static void Main()
        {
            String keepGoing = "y";//Works like a bool
            
            while(keepGoing.Equals("y", StringComparison.OrdinalIgnoreCase))//If true, keep looping
            {
                Console.Write("Enter an integer: ");//Enter a number
                try
                {
                    int val = Int32.Parse(Console.ReadLine());//Parse input to an integer
                    if (val < 0)
                    {
                        throw new ArgumentException("Negative factorials are undefined");
                    }
                    long fact = MathUtils.Factorial(val);
                    if (fact < 0 || val > 19)
                    {
                        if (fact < 0)
                        { throw new ArgumentException("An overflow has occurred and the result is inaccurate."); }
                        else
                        {
                            throw new ArgumentException("Cannot compute the factorial for values over 20.");
                        }
                    }
					Console.WriteLine($"Factorial({val}) = {fact}");

				}
				catch (ArgumentException)
                {
                    Console.WriteLine("Let's continue with a different number, no negatives, and nothing over 20.");
                }
                Console.Write("Another factorial? (y/n) ");
                keepGoing = Console.ReadLine();
            }
        }
    }
}
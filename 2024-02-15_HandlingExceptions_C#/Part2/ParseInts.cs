using System;

namespace Part2
{

    public class ParseInts
    {
        //Reads a line of text and prints the integers in the line.
        public static void Main()
        {
            (int val, int sum) = (0, 0);//if both variables of a tuple are the same, the ( , ) is not necessary and you only declare the variable type once
            Console.Write("Enter a line of text: ");
            String line = Console.ReadLine();

            String[] tokens = line.Split();

            //Compute a sum of the integers on the line
            for (int i = 0; i < tokens.Length; i++)
            {
                try
                { 
                    val = int.Parse(tokens[i]);
					sum += val;
				}//THEEXCEPTION}
                catch(Exception e) 
                {
                    Console.WriteLine($"\"{tokens[i]}\" is not a number");
                    Console.Write(Environment.NewLine);
                    Console.WriteLine(e.Message);
                    Console.Write(Environment.NewLine);
                }
                
                
            }

            Console.WriteLine("The sum of the integers on this line is " + sum);
        }
    }
}
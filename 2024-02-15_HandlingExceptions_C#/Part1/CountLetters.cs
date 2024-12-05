using System;

namespace IT100_ExceptionsLab
{
    public class CountLetters
    {
        //Reads a words from the standard input and prints the number of
        //  occurrences of each letter in that word.
        public static void Main()
        {
            int theLetterUnicode = 0;
            int[] counts = new int[26];
            //Get word from the user
            Console.Write("Enter a single word (letters only): ");
            String word = Console.ReadLine();

            //Convert to all upper case
            word = word.ToUpper();

            try
            {
                //Count frequency of each letter in string
                for (int i = 0; i < word.Length; i++)//For every character in word
                {
                    theLetterUnicode = (int)word[i];
                    char character = word[i];//ASCII character codes. 
                    //TODO, what if the character is less than 65
                    int x = character - 'A';//A=65.  B=66. C=67 and so on
                                            //so x is how far the character we are on is from A (like an array)
                    counts[x]++;//count[steps away from 'A'] ++.
                                //Will create an array of counts which increase for every instance of the letter
                                //  in the span of the for loop
                    
                }
            }
            catch (Exception e)
            {
#if DEBUG
                Console.WriteLine($"The character, '{(char)theLetterUnicode}' in your string was not a letter and threw an exception.");
                Console.WriteLine(e.Message);
#endif
            }

            //Print frequencies
            Console.WriteLine();
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] != 0)//If there were instances of the letter in the word
                {
                    Console.WriteLine((char)(i + 'A') + ": " + counts[i]);
                    //i + A turns back to unicode value A=65, B=66 and so on
                    //Casted to a char instead of an int
                    //counts[i] = how many instances of the letter in the word.
                }
            }
        }
    }
}

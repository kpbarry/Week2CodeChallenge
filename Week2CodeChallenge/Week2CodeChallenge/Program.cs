using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loop for FizzBuzz 0 => 20
            for (int i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }

            //Letter Counter
            LetterCounter('i', "I love biscuits and gravy. It’s the best breakfast ever.");
            LetterCounter('n', "Never gonna give you up. Never gonna let you down.");
            LetterCounter('s', "Sally sells seashells down by the seashore. She’s from Sussex.");

            Console.ReadKey();
        }
        static void FizzBuzz(int number)
        {
            //This condition must be checked first to ensure a # is divisible by both #s
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            //If divisible by 3 print Buzz
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            //Divisible by 5
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            //Not divisible by 3 or 5
            else
            {
                Console.WriteLine(number);
            }
        }

        static void LetterCounter(char letter, string inString)
        {
            //Counter variables
            int lowerLetterCount = 0, upperLetterCount = 0;

            //Cases for upper and lower case letters
            string lowerCase = letter.ToString().ToLower();
            string upperCase = letter.ToString().ToUpper();

            //Loop through every character in c to check if it's upper or lower case
            //Increment for each one found
            foreach (char c in inString)
            {
                if (c.ToString() == lowerCase)
                {
                    lowerLetterCount++;
                }
                if (c.ToString() == upperCase)
                {
                    upperLetterCount++;
                }
            }

            //HOORAY MATH
            int totalCount = upperLetterCount + lowerLetterCount;
            Console.WriteLine("Input: " + inString + "\n Number of lowercase " + letter.ToString().ToLower() + "'s" + " found: " + lowerLetterCount +
                "\n " + "Number of UPPERCASE " + letter.ToString().ToUpper() + "'s" + " found: " + upperLetterCount +"\n Total Number " + letter + "'s" + " found: " + totalCount);
        }


    }
}

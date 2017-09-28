using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionalsPracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int firstEntry = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number:");
            int secondEntry = int.Parse(Console.ReadLine());

            if (firstEntry == secondEntry)
            {
                Console.WriteLine("The numbers " + firstEntry + " and " + secondEntry + " are equal.");
            }

            else
            {
                Console.WriteLine("The numbers " + firstEntry + " and " + secondEntry + " are not equal.");
            }
            //
            //
            //
            //
            //
            //
            //

            Console.WriteLine("Enter a number and the return will be even or odd:");
            int modulusEntry = int.Parse(Console.ReadLine());

            if (modulusEntry % 2 == 0)
            {
                Console.WriteLine("The number " + modulusEntry + " is even.");
            }

            else
            {
                Console.WriteLine("The number " + modulusEntry + " is odd.");
            }

           //
           //
           //
           //
           //
           //
           //
           //

            Console.WriteLine("Enter a lower case letter for an English lesson: ");
            char letterEntered = char.Parse(Console.ReadLine());

            switch (letterEntered)
            {
                case 'a':
                    Console.WriteLine(letterEntered + " is a vowel");
                    break;

                case 'e':
                    Console.WriteLine(letterEntered + " is a vowel");
                    break;

                case 'i':
                    Console.WriteLine(letterEntered + " is a vowel");
                    break;

                case 'o':
                    Console.WriteLine(letterEntered + " is a vowel");
                    break;

                case 'u':
                    Console.WriteLine(letterEntered + " is a vowel");
                    break;

                default:
                    Console.WriteLine(letterEntered + " , You entered a consonant");
                    break;
            }
            //
            //
            //
            //
            //
            //

            //THERE IS NOT A PAUSE FOR USER ENTRY
            Console.WriteLine("Enter a whole number: ");
            int firstValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second whole number: ");
            int secondValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Finally, enter a third whole number: ");
            int thirdValue = int.Parse(Console.ReadLine());

            if (firstValue > secondValue && firstValue > thirdValue)
            {
                Console.WriteLine(firstValue + " is the largest value.");
            }

            else if (secondValue > firstValue && secondValue > thirdValue)
            {
                Console.WriteLine(secondValue + " is the largest value.");
            }

            else if (thirdValue > firstValue && thirdValue > secondValue)
            {
                Console.WriteLine(thirdValue + " is the largest value.");
            }

            else
            {
                Console.WriteLine("Go back to the start");
            }

            //
            //
            //
            //
            //
            //
            //
            //
            Console.WriteLine("Enter your first test scores: ");
            double testOne = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second test score: ");
            double testTwo = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your third test score: ");
            double testThree = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your fourth test score: ");
            double testFour = double.Parse(Console.ReadLine());

            double testTotal = testOne + testTwo + testThree + testFour;

            double testMean = testTotal / 4;

            Console.WriteLine("Your test average is " + testMean);
            

















        }
    }
}

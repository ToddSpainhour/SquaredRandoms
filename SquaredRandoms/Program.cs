using System;
using System.Collections.Generic;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Squared Randoms! (\b)");

            var randomNumber = new Random();

            List<int> listOfRandomNumbersBelowFifty = new List<int>();

            List<int> listOfSquaredNumbers = new List<int>();





            for (int i = 0; i < 21; i++)
            {
                var randonNumberUnder50 = randomNumber.Next(51);
                listOfRandomNumbersBelowFifty.Add(randonNumberUnder50);

            }



            // let's see the list of random numbers
            foreach (var number in listOfRandomNumbersBelowFifty)
            {
                Console.WriteLine(number);
            }




            // now let's square the numbers from above
            foreach (var number in listOfRandomNumbersBelowFifty)
            {
                //  number squaredand push to new list
                int squaredNumber = number * number;
                listOfSquaredNumbers.Add(squaredNumber);
            }



            foreach (var number in listOfSquaredNumbers)
            {
                Console.WriteLine($"Your squared number is {number}");
            }




        }
    }
}



/*
 * 1. Using the `Random` class, generate a list of 20 random numbers that are in the range of 1-50.

    ```csharp
    Random random = new Random();
    // Create a list
    // Populate the list
    ```

2. With the resulting List, populate a new List that contains each number squared. For example, if the original list is `2, 5, 3, 15`, the final list will be `4, 25, 9, 225`.
3. Then remove any number that is odd from the list of squared numbers.
 */

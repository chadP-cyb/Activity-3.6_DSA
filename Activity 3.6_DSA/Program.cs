using System;

/*DSA Activity 3.6 - [PACIA, Chad Edrei]
 * Sort and Lists 
 */

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var intList = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                intList.Add(new Random().Next(1, 10));
            }
            Console.WriteLine("Welcome to my GENERIC LIST PROGRAM");
            Console.WriteLine("The 20 random numbers are: ");

            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write(intList[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Histogram:");

            for (int i = 1; i <= 9; i++)
            {
                Console.Write($"{i}: ");
                for (int j = 0; j < intList.Count(x => x == i); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            Console.ReadKey();
        }
    }
}

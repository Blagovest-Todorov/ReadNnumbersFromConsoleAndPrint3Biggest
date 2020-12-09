using System;
using System.Linq;
using System.Collections.Generic;

namespace _08.TakingTheThreeBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Read from the console the n numebers'
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];  // cre3ate an array of inserted numbers

            for (int i = 0; i < n; i++)   // create a for cycle with the exact count of entered numbers // so we enter 5 numbers , 
                // the array must contain  5 elements
            {
                int currNum = int.Parse(Console.ReadLine());  // create a current variable for each entered element and call it by console
                numbers[i] = currNum;  // every received by the console number must be inerted into the created array to be easy later to sort it
            }
            Console.WriteLine("the three largest numbers are : " + string.Join(" ", numbers.OrderByDescending(num => num).Take(3)));
            // We print the 3 big numbers, but before that we order the array by Descending order so the first 3 numbers will be the largest 3, 
            // and after the array in sorted descending we take the  first 3 numbers and prin them as a string inline collection
        }
    }
}

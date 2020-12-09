using System;
using System.Linq;
using System.Collections.Generic;

namespace _09.Taking3LargestNumbers
{
    class Program
    {
        static void Main(string[] args)   // split --we get everithign as a string, we move out the whiat espace , we convert it to int , ToArray
        {
            int[] numbers = Console.ReadLine().Split(' ')
                                    .Select(int.Parse)
                                    .ToArray();

            // Console.WriteLine(string.Join(" ", numbers.OrderByDescending(num => num).Take(3)));

            int[] largestThreeNumbers = numbers   //We take the existinfg  collection we fetched by the console and create with it new Array
                                               .OrderByDescending(x => x)  //order the collection by Descending so firsdt 3 nums are the largest
                                               .Take(3)  //We take the  first 3 largest numbers from old array and we create new array with those 3  numbers 
                                               .ToArray();
            Console.WriteLine(string.Join("-> ", largestThreeNumbers));  //We priont as a string the three elements ;
        }
    }
}

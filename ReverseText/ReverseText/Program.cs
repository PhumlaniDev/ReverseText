using System;
using System.Linq;

namespace ReverseText
{
    class Program
    {
        static void Main(string[] args)
        {
            //read user input
            string name = Console.ReadLine();

            //store user input to char array
            char[] chars = name.ToCharArray();

            //used result char array to store output
            char[] result = new char[chars.Length];

            //here we swap the first value with last value until the whole array is reversed
            for (int i = 0, j = name.Length - 1; i < name.Length; i++, j--)
            {
                result[i] = chars[j];
               }

                Console.WriteLine(result.ToArray());
        }          
    }
}

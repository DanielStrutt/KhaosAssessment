using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)//Function which accepts an array of integers and displays the two highesy integers in the array.
        {
            int i, n, max, maxTwo;//Declaring variables.
            Console.Write("Please enter the amount of values contained in the array: ");//This must be a positive number otherwise an error will occurr.
            n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            max = 0;
            maxTwo = 0;
            for (i = 0; i < n; i++)
            {
                Console.Write("Input Number[{0}]: ", i);
                num[i] = Convert.ToInt32(Console.ReadLine());
                if (maxTwo < num[i])
                    if (max < num[i]) //Identifies the two largest values in the array given that they are different.
                    {
                        maxTwo = max; //This is used for when the two largest values in the array are equal to each other.
                        max = num[i];
                    }
                    else
                    {
                        maxTwo = num[i];
                    }
            }
            Console.Write("The largest number in the array is {0}, and second largest is {1}.", max, maxTwo);
            Console.ReadLine();
        }
    }
}

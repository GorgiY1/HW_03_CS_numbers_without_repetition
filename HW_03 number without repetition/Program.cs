using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03_number_without_repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////

            /*Написать программу, которая находит в массиве значения, 
             * повторяющиеся два и более раз, 
             * и показывает их на экран без дублирования.*/

            Random random = new Random(); // search random number

            int[] arr = new int[20];
            int tmp = -1; 
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 10); // filling an array with random numbers
            }

            Array.Sort(arr); // array sorting is very important without sorting will not work

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j] && arr[i] != tmp)//here the variable "tmp" does not allow this number to be repeated 
                    {
                        Console.Write("{0} ", arr[i]); // show non-repeated numbers in console
                        tmp = arr[i]; // the variable "tmp" has the last number that is displayed on the console and does not allow this number to be repeated 
                        break;
                    }
                }
            }
            
            Console.WriteLine();

            foreach (int item in arr) // show all array to console 
            { 
                Console.Write("{0} ", item);
            }

            ////////////////////////////////////////////////
            
            Console.ReadKey();
        }
    }
}

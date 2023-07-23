using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseV
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] theArray = { 1, 2, 3, 4, 5, 6, 7 };
            //Pass the array using ref; 
            FillArray(ref theArray);
            //  Display the updated array; 
            System.Console.WriteLine("Array elements are:");
            for (int i = 0; i < theArray.Length; i++)
            { System.Console.Write(theArray[i] + "");
            }
        }
        static void FillArray(ref int[] arr)
        { // Create the array on demand: 
            if (arr== null) { arr = new int [10]; } //Fill the array; 
            arr[0] = 1111; arr[4] = 5555; }
        }
}

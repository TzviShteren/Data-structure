using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartOfData
{
    internal class ExerciseUtils
    {
        // exercise 1
        public static int CalculateOddSum(int[] array)
        {
            int sum = 0; // 1
                         //1         //n             //n
            for (int i = 0; i < array.Length; i++)
            { //n
                if (array[i] % 10 == 0) // 1 
                    sum += array[i]; // 1
            }
            return sum; // 1
        } // 3n + 3 || O(n)


        // exercise 2
        public static (int, int) FindMaximumTwo(int[] array)
        {
            int max1 = array[0]; // 1
            int max2 = array[1]; // 1 
            for (int i = 2; i < array.Length - 1; i++) // 1 + 2n
            { // n
                if ((array[i] + array[i + 1]) > (max1 + max2)) // 1 
                {
                    max1 = array[i]; // 1
                    max2 = array[i + 1]; // 1
                }
            }
            return (max1, max2); // 1
        } // 4 + 5n || O(n)

        // exercise 3
        public static bool ContainsNumber(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++) // 1 + 2n
            {
                if (array[i] == number) // 1
                {
                    return true; // 1
                }
            }
            return false; // 1
        }// 2 + 4n || O(n)


        // exercise 4
        public static int CSumOfAllTriplets(int[] array)
        {
            int max1 = array[0]; // 1
            int max2 = array[1]; // 1 
            int max3 = array[2]; // 1 
            if (array.Length == 3) { return max1 + max2 + max3; } // 1
            for (int i = 3; i < array.Length - 2; i++) // 1 + 2n
            { // n
                if ((array[i] + array[i + 1] + array[i + 2]) > (max1 + max2 + max3)) // 1 
                {
                    max1 = array[i]; // 1
                    max2 = array[i + 1]; // 1
                    max3 = array[i + 2]; // 1
                }
            }
            return max1 + max2 + max3; // 1
        }// 5 + 6n || O(n)

        // exercise 5
        public static (int, int) FindLastPairWithProduct(int[] array, int product)
        {
            for (int i = array.Length - 1; i < 1; i--) // 1 + 2n
            { // n
                if (array[i] * array[i - 1] == product) // 1 
                {
                    return (array[i], array[i - 1]); // 1
                }
            }
            throw new NotImplementedException("No result found"); // 1
        }// 1 + 4n || O(n)

        // exercise 6
        public static int CountEvenNumbers(int[] array)
        {
            int tamp = 0; // 1
            for (int i = 0; i < array.Length; i++) // 1 + 2n
            { // n
                if (array[i] % 10 == 0) // 1 
                    tamp++; // 1
            }
            return tamp; // 1
        }// O(n)


        // exercise 7
        public static int[] MergeSortedArraysUnique(int[] array1, int[] array2)
        {
            int i1 = 0, i2 = 0; // 2
            int array1Len = array1.Length, array2Len = array2.Length; // 2
            int theLongest = ((array1Len > array2Len) ? array1Len : array2Len); // 2
            int[] newArray = [array1Len + array2Len]; // 2

            for (int i = 0; i < newArray.Length; i++) // 1 + 2n
            { // n
                if (i1 > array1Len)
                {
                    newArray[i] = array2[i2];
                    i2++;
                }
                if (array1[i1] > array2[i2] || i1 > array1Len)
                {
                    newArray[i] = array2[i2];
                    i2++;
                }
                if (array1[i1] < array2[i2] || i2 > array2Len)
                {
                    newArray[i] = array1[i1];
                    i1++;
                }
            }
            return newArray; // 1
        }// O(n)
    }
}

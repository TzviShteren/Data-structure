using StartOfData;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine($"multiply: {RecursionQuestions.multiply(4, 5)}");

            //Console.WriteLine($"sumOfDigits: {RecursionQuestions.sumOfDigits(251)}");

            //Console.WriteLine($"reversed: {RecursionQuestions.reversed(56456)}");

            //int[] ints = { 1, 2, 3 };
            //Console.WriteLine($"findSum: {RecursionQuestions.findSum(ints, ints.Length)}");

            Console.WriteLine($"divide: {RecursionQuestions.divide(20, 2)}"); // 10

            //Console.WriteLine($"isPalindrome: gdsub: {RecursionQuestions.isPalindrome("gdsub")}"); // false
            //Console.WriteLine($"isPalindrome: asdsa: {RecursionQuestions.isPalindrome("asdsa")}"); // true
            
            //Console.WriteLine($"isPalindrome: 120: {RecursionQuestions.decimalToBinary(120)}"); // 1111000
            



        }
        

        static public void SelectionSort(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                int minIndex = 0;
                for (int j = i + 1; j < ints.Length; j++)
                {
                    if (ints[j] < ints[minIndex])
                    {
                        ints[minIndex] = ints[j];
                    }
                }
                if (ints[i] != minIndex)
                {
                    ints[i] = ints[minIndex] + ints[i];
                    ints[minIndex] = ints[i] - ints[minIndex];
                    ints[i] -= ints[minIndex];

                    //(ints[i], ints[minIndex]) = (ints[minIndex], ints[i]);
                }
            }
        }


    }
}
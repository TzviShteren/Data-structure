namespace StartOfData
{
    internal class RecursionQuestions
    {
        // 1
        public static int multiply(int a, int b)
        {
            if (b == 0) return 0;
            return a + multiply(a, b - 1);
        }

        // 2
        public static long sumOfDigits(long n)
        {
            if (n < 10) return n;
            return (n % 10) + sumOfDigits(n / 10);
        }

        // 3
        public static int power(int a, int b)
        {
            if (b == 0) return 0;
            return a * power(a, b - 1);
        }

        // 4
        public static double reversed(int n)
        {
            if (n < 10) return n;
            int lengthOfNumber = n.ToString().Count();
            double multiply = Math.Pow(10, lengthOfNumber) / 10;
            return ((n % 10) * multiply) + reversed(n / 10);
        }

        // 5
        public static int findSum(int[] arr, int n)
        {
            if (n == 0) return 0;

            return arr[n - 1] + findSum(arr, n - 1);
        }

        // 6
        public static int divide(int a, int b)
        {
            if (a - b < 0) return 0;
            return 1  +  divide(a - b, b);
        }
        
        // 7
        public static bool isPalindrome(string str)
        {
            int len = str.Length;
            if (len <= 1) return true;

            if (str[0] != str[len - 1]) return false;
            
            return isPalindrome(str.Substring(1, len - 2));
        }

        // 8
        public static string decimalToBinary(int n)
        {
            if (n == 0) return string.Empty;
            string str = (n % 2 == 1) ? "1": "0";
            return decimalToBinary(n / 2) + str;
        }
        
    }
}

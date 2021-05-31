using System;

namespace Question_1_Solution
{

    class Question1
    {

        public static int Arrange(int[] arr, int length)
        {
            int j = 0, i;
            for (i = 0; i < length; i++)
            {
                if (arr[i] <= 0)
                {
                    int temp;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j++;
                }
            }

            return j;
        }

        public static int findMissingPositive(int[] arr, int length)
        {
            int i;
            for (i = 0; i < length; i++)
            {
                if (Math.Abs(arr[i]) - 1 < length && arr[Math.Abs(arr[i]) - 1] > 0)
                    arr[Math.Abs(arr[i]) - 1] = -arr[Math.Abs(arr[i]) - 1];
            }

            for (i = 0; i < length; i++) 
            if (arr[i] > 0)
                return i + 1;
            return length + 1;
        
        }

        public static int findMissingNumber(int[] arr, int length)
        {
            int shift = Arrange(arr, length);
            int[] arr2 = new int[length - shift];
            int j = 0;

            for (int i = shift; i < length; i++)
            {
                arr2[j] = arr[i];
                j++;
            }
            return findMissingPositive(arr2, j);
        }

        // An Example to Test code
        public static void Main()
        {
            int[] arr = { 1, 5, 7, 4, 1, 2 };
            int arr_length = arr.Length;
            int missing = findMissingNumber(arr, arr_length);
            Console.WriteLine("The smallest positive integer that is missing is " + missing);
        }
    }

}

using System;

namespace Algorithms_Exercises
{
    class Program
    {
        static void Main(string[] args)

        {

            List<int> myList = new List<int>(new int[] { 2, 3, 7 });
            
            LargestTwoElementConsecutiveSum(myList);
        }

        private static void LargestTwoElementConsecutiveSum(List<int> [] arr)
        {
            int first, second;
            if (arr[0] > arr[1])
            {
                first = arr[0];
                second = arr[1];
            }
            else
            {
                first = arr[1];
                second = arr[0];
            }


            for (int i = 2; i < arr.Length; i++)
            {

                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }


                else if (arr[i] > second &&
                         arr[i] != first)
                    second = arr[i];
            }
            return (first + second);
        }
    }
    }
}

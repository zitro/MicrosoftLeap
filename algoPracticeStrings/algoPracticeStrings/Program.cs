using System;

namespace algoPracticeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] myArr = { "b", "r", "y", "a", "n" };
            Console.WriteLine(reverse(myArr));

           
            
        }

        private static void reverse(char[] myArr)
        {
            char[] newArr = new char[5];
            for (int i = 0, j = myArr.Length - 1; i < myArr.Length; i++, j--)
            {
                newArr[i] = myArr[j];
            }
            
            newArr.ToString;
        }
    }
}

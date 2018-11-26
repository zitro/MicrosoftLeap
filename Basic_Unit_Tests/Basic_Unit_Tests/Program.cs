using System;

namespace Basic_Unit_Tests
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        public static int SumArray(int[] values)
        {
            var sum = 0;

            if (values == null || values.Length == 0)
            {
                return sum;
            }
            foreach (var value in values)
            {
                sum += value;
            }
            return sum;
        }

    }
}

﻿using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] array = null;
                int[] array2 = new int[5] { 1, 2, 3, 4, 5 };
                var indexTooLow = -1;
                var indexTooHigh = Int32.MaxValue;
                var indexJustRight = 3;

                //GetValueAtIndex(array, -1);
                //GetValueAtIndex(array2, indexTooLow);
                //GetValueAtIndex(array2, indexTooHigh);
                GetValueAtIndex(array2, indexJustRight);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        public static int GetValueAtIndex(int[] values, int index)
        {
            Console.WriteLine("Entering GetValueAtIndex");

            try
            {
                if (values == null)
                    throw new ArgumentNullException("values");

                var minIndex = 0;
                var maxIndex = values.Length - 1;
                if (index < minIndex || index > maxIndex)
                    throw new IndexOutOfRangeException("Index must be between " + minIndex + " and " + maxIndex);
            }
            catch
            {
                Console.WriteLine("Error in GetValueAtIndex");
                throw;
            }
            finally
            {
                Console.WriteLine("Exiting GetValueAtIndex");
            }

            return values[index];
        }
    }
}

/*
 
3.	Manually test this logic with the following cases and verify your code works correctly:
a.	Values = null
b.	Values = not null, Index is “too small”
c.	Values = not null, Index is “too large”
d.	Values = not null, Index is “just right”


    */

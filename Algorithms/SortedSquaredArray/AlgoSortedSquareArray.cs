using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.SortedSquaredArray
{
    public class AlgoSortedSquareArray
    {
        public static int[] SortedSquareArray(int[] array)
        {
            int[] squares = new int[array.Length];

            int c = 0;
            foreach(int x in array)
            {
                squares[c] = (int)Math.Pow(x, 2);
                c++;
            }

            Array.Sort(squares);

            return squares;
        }

        public static int[] SortedSquareArray2(int[] array)
        {
            int[] squares = new int[array.Length];
            int i = squares.Length - 1;
            int lowest = 0;
            int highest = i;

            while (lowest != highest)
            {
                if (Math.Abs(array[lowest]) > Math.Abs(array[highest]))
                {
                    squares[i] = (int)Math.Pow(array[lowest], 2);
                    lowest++;
                }
                else
                {
                    // Values are equal or above condition not true so the
                    // value to insert has to be the higher value
                    squares[i] = (int)Math.Pow(array[highest], 2);
                    highest--;
                }
                i--;
            }
            squares[i] = (int)Math.Pow(array[highest], 2);

            return squares;
        }
    }
}

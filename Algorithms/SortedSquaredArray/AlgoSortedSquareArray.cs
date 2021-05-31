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
    }
}

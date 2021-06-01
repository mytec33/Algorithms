using Algorithms.SortedSquaredArray;
using Algorithms.TournamentWinner;

using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] ssaTest = new int[] { 1, 2, 3, 5, 6, 8, 9 };
            //int[] ssaTest = new int[] { -2, -1 };
            int[] ssaTest = new int[] { -10, -5, 0, 5, 10 };
            //int[] ssaTest = new int[] { -7, -5, -4, 3, 6, 8, 9 };
            //var ssaResults = AlgoSortedSquareArray.SortedSquareArray(ssaTest);
            var ssaResults = AlgoSortedSquareArray.SortedSquareArray2(ssaTest);
            Console.WriteLine($"{string.Join(", ", ssaResults)}");



            //string tournamentWinner = 
            //    AlgoTournamentWinner.TournamentWinner(AlgoTournamentWinner.competitions, 
            //    AlgoTournamentWinner.results);
            //Console.WriteLine($"Winner: {tournamentWinner}");


        }
    }
}

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
            int[] ssaTest = new int[] { -2, -1 };
            var ssaResults = AlgoSortedSquareArray.SortedSquareArray(ssaTest);
            Console.WriteLine($"{string.Join(", ", ssaResults)}");

            //string tournamentWinner = 
            //    AlgoTournamentWinner.TournamentWinner(AlgoTournamentWinner.competitions, 
            //    AlgoTournamentWinner.results);
            //Console.WriteLine($"Winner: {tournamentWinner}");


        }
    }
}

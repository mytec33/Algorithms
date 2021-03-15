using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> competitions = new List<List<string>>
            {
                new List<string> {"HTML", "C#" },
                new List<string> {"C#", "Python" },
                new List<string> {"Python", "HTML" }
            };

            List<int> results = new List<int> { 0, 0, 1 };
            string tournamentWinner = TournamentWinner(competitions, results);
            Console.WriteLine($"Winner: {tournamentWinner}");
        }

        public static string TournamentWinner(List<List<string>> competitions, List<int> results)
        {
            Dictionary<string, int> scores = new Dictionary<string, int>();
            int index = 0;
            string team;

            foreach (List<string> items in competitions)
            {
                int score = results[index];

                team = (score == 1) ? items[0] : items[1];
                if (scores.ContainsKey(team))
                {
                    scores[team] = scores[team] + 3;
                }
                else
                {
                    scores.Add(team, 3);
                }

                index++;
            }

            int value = 0;
            string winner = "";
            foreach(KeyValuePair<string, int> valuePair in scores)
            {
                if (valuePair.Value > value)
                {
                    value = valuePair.Value;
                    winner = valuePair.Key;
                }
            }

            return winner;
        }
    }
}

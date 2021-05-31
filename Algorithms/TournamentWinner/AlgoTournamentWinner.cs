using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.TournamentWinner
{
    class AlgoTournamentWinner
    {
        public static readonly List<List<string>> competitions = new()
        {
            new List<string> {"HTML", "C#" },
            new List<string> {"C#", "Python" },
            new List<string> { "Python", "HTML" }
        };
        
        public static readonly List<int> results = new() { 0, 0, 1 };

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
            foreach (KeyValuePair<string, int> valuePair in scores)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Homework
{
    public class Game
    {
        private Team team1;
        private Team team2;
        public Referee Referee { get; set; }
        public List<Referee> AssistantReferees { get; set; }
        public List<Goal> Goals { get; set; }
        public string Result { get; set; }
        public Team Winner { get; set; }

        public Team Team1
        {
            get { return team1; }
            set
            {
                if (value.Players.Count == 11)
                {
                    team1 = value;
                }
                else
                {
                    throw new ArgumentException("Team1 must have exactly 11 players.");
                }
            }
        }

        public Team Team2
        {
            get { return team2; }
            set
            {
                if (value.Players.Count == 11)
                {
                    team2 = value;
                }
                else
                {
                    throw new ArgumentException("Team2 must have exactly 11 players.");
                }
            }
        }
    }
}

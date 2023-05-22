using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Homework
{
    public class Team
    {
        public Coach Coach {get;set;}
        private List<FootballPlayer> players;
        public List<FootballPlayer> Players
        {
            get { return players; }
            set
            {
                if (value.Count >= 11 && value.Count <= 22)
                {
                    players = value;
                }
                else
                {
                    throw new ArgumentException("Number of players must be between 11 and 22.");
                }
            }
        }
        public int AverageAge()
        {
            int totalAge = 0;
            foreach (var player in Players)
            {
                totalAge += player.Age;
            }
            return (int)totalAge / Players.Count;
        }
    }
}

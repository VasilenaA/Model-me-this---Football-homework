using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Homework
{
    public class Goal
    {
        public int Minute { get; set; }
        public FootballPlayer Player { get; set; }
        public Goal(int minute, FootballPlayer player)
        {
            Minute = minute;
            Player = player;
        }
    }
}

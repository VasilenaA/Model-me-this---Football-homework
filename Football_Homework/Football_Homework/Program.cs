using Football_Homework;
using System.Linq;
using System.Numerics;


public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();

        FootballPlayer[] players = new FootballPlayer[22];
        for (int i = 0; i < 22; i++)
        {
            players[i] = new FootballPlayer("Player " + (i + 1), i + 1, random.Next(18,38), random.Next(168, 200));
        }

        Coach coach = new Coach("Coach John", 45);
        Coach coach1 = new Coach("Coach Georgi", 50);

        // Create teams
        Team team1 = new Team { Coach = coach, Players = players[0..11].ToList() };
        Team team2 = new Team { Coach = coach1, Players = players[11..22].ToList() };

        // Create game
        Game newGame = new Game
        {
            Team1 = team1,
            Team2 = team2,
            Goals = new List<Goal>(),
        };
        for (int i = 0; i < 10; i++)
        {
            int minute = random.Next(0,90);
            if (random.Next(2) == 0)
            {
                FootballPlayer goalMaker = team1.Players[random.Next(11)];
                newGame.Goals.Add(new Goal(minute,goalMaker));
            }
            else
            {
                FootballPlayer goalMaker = team2.Players[random.Next(11)];
                newGame.Goals.Add(new Goal(minute, goalMaker));
            }
        }

        int goalsTeam1 = 0;
        int goalsTeam2 = 0;
        foreach (Goal goal in newGame.Goals)
        {
            if (newGame.Team1.Players.Contains(goal.Player))
            {
                goalsTeam1++;
            }
            else if (newGame.Team2.Players.Contains(goal.Player))
            {
                goalsTeam2++;
            }
        }

        if (goalsTeam1 > goalsTeam2)
        {
            newGame.Winner = newGame.Team1;
            newGame.Result = "Team 1 wins!";
        }
        else if (goalsTeam2 > goalsTeam1)
        {
            newGame.Winner = newGame.Team2;
            newGame.Result = "Team 2 wins!";
        }
        else
        {
            newGame.Result = "It's a draw!";
        }

        Console.WriteLine($"Game result: {newGame.Result}");
        Console.WriteLine($"The winner is: {( newGame.Winner.Coach.Name)}");
        Console.WriteLine("Avg age team 1: " + team1.AverageAge());
        Console.WriteLine("Avg age team 2: " + team2.AverageAge());

    }
}


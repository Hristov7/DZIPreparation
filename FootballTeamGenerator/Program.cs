namespace FootballTeamGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] parts = input.Split(';', StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];
                string teamName = parts[1];
                try
                {
                    switch (command)
                    {
                        case "Team":
                            Team team = new Team(teamName);
                            teams.Add(team);
                            break;
                        case "Add":
                            string playerName = parts[2];
                            int endurance = int.Parse(parts[3]);
                            int sprint = int.Parse(parts[4]);
                            int dribble = int.Parse(parts[5]);
                            int passing = int.Parse(parts[6]);
                            int shooting = int.Parse(parts[7]);

                            Statistics stats = new Statistics(endurance, sprint, dribble, passing, shooting);
                            Player player = new Player(playerName, stats);
                            if (teams.Any(t => t.Name == teamName))
                            {
                                Team foundTeam = teams.FirstOrDefault(t => t.Name == teamName);
                                foundTeam.AddPlayer(player);
                            }
                            else
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                            }
                            break;
                        case "Remove":
                            if (teams.Any(t => t.Name == teamName))
                            {
                                Team foundTeam = teams.FirstOrDefault(t => t.Name == teamName);
                                if (foundTeam.NumberOfPlayers.Any(p => p.Name == parts[2]))
                                {
                                    Player foundPlayer = foundTeam.NumberOfPlayers.FirstOrDefault(p => p.Name == parts[2]);
                                    foundTeam.NumberOfPlayers.Remove(foundPlayer);
                                }
                                else
                                {
                                    Console.WriteLine($"Player {parts[2]} is not in {teamName} team.");
                                }
                            }
                            break;
                        case "Rating":
                            if (teams.Any(t => t.Name == teamName))
                            {
                                Team foundTeam = teams.FirstOrDefault(t => t.Name == teamName);
                                if (foundTeam.NumberOfPlayers.Count == 0)
                                {
                                    Console.WriteLine($"{foundTeam.Name} - 0");
                                }
                                else
                                {
                                    Console.WriteLine($"{foundTeam.Name} - {foundTeam.ReturnRating()}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                            }
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
    }
}
/*
Team;Arsenal
Add;Arsenal;Kieran_Gibbs;75;85;84;92;67
Add;Arsenal;Aaron_Ramsey;95;82;82;89;68
Remove;Arsenal;Aaron_Ramsey
Rating;Arsenal
END

Team;Arsenal
Add;Arsenal;Kieran_Gibbs;75;85;84;92;67
Add;Arsenal;Aaron_Ramsey;195;82;82;89;68
Remove;Arsenal;Aaron_Ramsey
Rating;Arsenal
END

Team;Arsenal
Rating;Arsenal
END

*/
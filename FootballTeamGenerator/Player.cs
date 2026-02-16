namespace FootballTeamGenerator
{
    public class Player
    {
        public Player(string name, Statistics stats)
        {
            Name = name;
            Stats = stats;

            this.SkillLevel = (double)(stats.Endurance + stats.Sprint + stats.Dribble + stats.Passing + stats.Shooting) / 5;
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new ArgumentException("A name should not be empty."); }
                _name = value;
            }
        }
        public Statistics Stats { get; set; }
        private double SkillLevel { get; set; }

        public double ReturnSkilllevel()
        {
            return this.SkillLevel;
        }
    }
}

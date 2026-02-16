namespace FootballTeamGenerator
{
    public class Team
    {
        public Team(string name)
        {
            this.Name = name;
            NumberOfPlayers = new List<Player>();
        }

        private string _name;

        public List<Player> NumberOfPlayers { get; set; }
        public string Name 
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new ArgumentException("A name should not be empty."); }
                _name = value;
            }
        }
        public int Rating { get; set; }

        public void AddPlayer(Player player)
        {
            if (player != null) this.NumberOfPlayers.Add(player);
        }
        public void RemovePlayer(Player player)
        {
            if(NumberOfPlayers.Contains(player)) this.NumberOfPlayers.Remove(player);
        }

        public int ReturnRating()
        {
            this.Rating =  (int)Math.Round(NumberOfPlayers.Average(p => p.ReturnSkilllevel()));
            return Rating;
        }
    }
}

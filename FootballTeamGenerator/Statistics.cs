namespace FootballTeamGenerator
{
    public class Statistics
    {
        public Statistics(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }
        private int _endurance;
        private int _sprint;
        private int _dribble;
        private int _passing;
        private int _shooting;

        public int Endurance 
        {
            get
            {
                return _endurance;
            }
            set
            {
                if(value <0 || value > 100) { throw new ArgumentException("Endurance should be between 0 and 100."); }
                _endurance = value;
            }
        }
        public int Sprint
        {
            get
            {
                return _sprint;
            }
            set
            {
                if (value < 0 || value > 100) { throw new ArgumentException("Sprint should be between 0 and 100."); }
                _sprint = value;
            }
        }
        public int Dribble
        {
            get
            {
                return _dribble;
            }
            set
            {
                if (value < 0 || value > 100) { throw new ArgumentException("Dribble should be between 0 and 100."); }
                _dribble = value;
            }
        }
        public int Passing
        {
            get
            {
                return _passing;
            }
            set
            {
                if (value < 0 || value > 100) { throw new ArgumentException("Passing should be between 0 and 100."); }
                _passing = value;
            }
        }
        public int Shooting
        {
            get
            {
                return _shooting;
            }
            set
            {
                if (value < 0 || value > 100) { throw new ArgumentException("Shooting should be between 0 and 100."); }
                _shooting = value;
            }
        }
    }
}

namespace PizzaFactory
{
    public class Pizza
    {
        public Pizza(string name)
        {
			this.Name = name;
			this._toppings = new();
        }
        private string _name;

		public string Name
		{
			get { return _name; }
			set
			{
				if (string.IsNullOrWhiteSpace(value) || value.Length <1 || value.Length>15) throw new Exception("Pizza name should be between 1 and 15 symbols.");
				_name = value;
			}
		}

		private Dough _dough;

		public Dough Dough
		{
			get { return _dough; }
			set { _dough = value; }
		}

		private List<Topping> _toppings;

        public void AddTopping(Topping topping)
        {
            if (_toppings.Count >= 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            _toppings.Add(topping);
        }
        public int NumberOfToppings => _toppings.Count;

        public double Calories()
		{
			double sum = 0;
			foreach (var topping in _toppings)
			{
				sum += topping.CaloriesPerGram();
			}
			sum += this.Dough.CaloriesPerGram();
			return sum;
		}
	}
}

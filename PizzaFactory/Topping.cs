namespace PizzaFactory
{
    public class Topping
    {
        public Topping(string toppingType, double weight)
        {
            this.ToppingType = toppingType;
			this.Weight = weight;
        }
        //meat (месо), veggies (зеленчуци), cheese (сирене) и sauce (сос)
        private string _toppingType;

		public string ToppingType
		{
			get { return _toppingType; }
			set
			{
				if (value != "meat" && value != "veggies" && value != "cheese" && value != " sauce") throw new Exception($"Cannot place {value} on top of your pizza.");
				_toppingType = value;
			}
		}

		private double _weight;

		public double Weight
		{
			get { return _weight; }
			set
			{
				if (value < 1 && value > 50) throw new Exception($"{ToppingType} weight should be in the range [1..50].");
				_weight = value;
			}
		}

		public double CaloriesPerGram()
		{
			double modificator = 0;
			switch (ToppingType)
			{
				case "Meat":
					modificator = 1.2;
					break;
				case "Veggies ":
					modificator = 0.8;
					break;
				case "Cheese ":
					modificator = 1.1;
					break;
				case "Sauce ":
					modificator = 0.9;
					break;
			}
			return 2 * this.Weight * modificator;
		}
	}
}

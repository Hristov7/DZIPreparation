using System.Data;

namespace PizzaFactory
{
    public class Dough
    {
        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }
        //white (бял), или wholegrain (пълнозърнест).
        private string _flourType;

		public string FlourType
		{
			get { return _flourType; }
			set
			{
				if (value.ToLower() != "white" && value.ToLower() != "wholegrain") throw new Exception("Invalid type of dough.");

				_flourType = value;
			}
		}

        //crispy (хрупкава), chewy (гъвкава) или homemade (домашна)
        private string _bakingTechnique;

		public string BakingTechnique
		{
			get { return _bakingTechnique; }
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                _bakingTechnique = value;
            }
        }

		private double _weight;

		public double Weight
		{
			get { return _weight; }
			set
			{
				if (value < 1 || value > 200) throw new Exception("Dough weight should be in the range [1..200].");
				_weight = value;
            }
		}

        public double CaloriesPerGram()
        {
            double modificator = 0;
            double secondModificator = 0;
            switch (FlourType)
            {
                case "White":
                    modificator = 1.5;
                    break;
                case "Wholegrain ":
                    modificator = 1.0;
                    break;
            }
            switch (BakingTechnique)
            {
                case "Crispy":
                    secondModificator = 0.9;
                    break;
                case "Chewy ":
                    secondModificator = 1.1;
                    break;
                case "Homemade ":
                    secondModificator = 1.0;
                    break;
            }
            return 2 * this.Weight * modificator * secondModificator;
        }
    }
}

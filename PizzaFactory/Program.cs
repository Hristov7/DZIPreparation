namespace PizzaFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            try
            {
                while ((input = Console.ReadLine()) != "END")
                {
                    string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    string type = parts[0];
                    Pizza pizza = null;
                    switch (type)
                    {
                        case "Pizza":
                            pizza = new Pizza(parts[1]);
                            break;
                        case "Dough":
                            Dough dough = new Dough(parts[1], parts[2], double.Parse(parts[3]));
                            pizza.Dough = dough;
                            break;
                        case "Topping":
                            Topping topping = new Topping(parts[1], double.Parse(parts[3]));
                            pizza.AddTopping(topping);
                            break;
                    }
                    Console.WriteLine($"{pizza.Name} - {pizza.Calories():F2} Calories.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
/*
Pizza Meatless
Dough Wholegrain Crispy 100
Topping Veggies 50
Topping Cheese 50
END

Pizza Burgas
Dough White Homemade 200
Topping Meat 123
END

Pizza Bulgarian
Dough White Chewy 100
Topping Sauce 20
Topping Cheese 50
Topping Cheese 40
Topping Meat 10
Topping Sauce 10
Topping Cheese 30
Topping Cheese 40
Topping Meat 20
Topping Sauce 30
Topping Cheese 25
Topping Cheese 40
Topping Meat 40
END

Pizza Bulgarian
Dough White Chewy 100
Topping Sirene 50
Topping Cheese 50
Topping Krenvirsh 20
Topping Meat 10
END

*/
namespace _04.PizzaCalories.Utilities
{
    public class ExceptionMessages
    {
        //Dough Messages
        public const string InvalidDoughType = "Invalid type of dough.";
        public const string InvalidDoughWeight = "Dough weight should be in the range [1..200].";

        //Topping Messages
        public const string InvalidToppingType = "Cannot place {0} on top of your pizza.";
        public const string InvalidToppingWeight = "{0} weight should be in the range [1..50].";
        public const string InvalidToppingCount = "Number of toppings should be in range [0..10].";

        //Pizza Messages
        public const string InvalidPizzaName = "Pizza name should be between 1 and 15 symbols.";
    }
}

using ExtensionMethods.Interfaces;

namespace ExtensionMethods.Extensions
{
    public static class DrinkExtensions
    {
        public static string GetDescription(this IDrink drink) => $"This drink has a quantity of {drink.Quantity} liters.";

    }
}

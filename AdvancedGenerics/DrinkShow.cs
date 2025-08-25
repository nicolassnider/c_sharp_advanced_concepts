namespace AdvancedGenerics
{
    public class DrinkShow : IShow<Drink>
    {
        public void Show(Drink drink) => Console.WriteLine($"This drink has {drink.Quantity} ml");
    }
}

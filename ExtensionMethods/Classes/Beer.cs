using ExtensionMethods.Interfaces;

namespace ExtensionMethods.Classes
{
    public class Beer : IDrink
    {
        public decimal Quantity { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }

    }
}

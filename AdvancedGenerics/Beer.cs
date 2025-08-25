using AdvancedGenerics.Interfaces;

namespace AdvancedGenerics
{
    public class Beer : Drink, IInfo
    {
        private string _name;
        public Beer(string name, int quantity) : base(quantity)
        {
            _name = name;
        }

        public string Name => _name;

        public string GetInfo() => $"Beer: {Name}, Quantity: {Quantity}";
    }
}

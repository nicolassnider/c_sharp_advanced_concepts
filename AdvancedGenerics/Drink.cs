namespace AdvancedGenerics
{
    public class Drink
    {
        private int _quantity;

        public Drink(int quantity)
        {
            _quantity = quantity;
        }

        public int Quantity => _quantity;
    }
}

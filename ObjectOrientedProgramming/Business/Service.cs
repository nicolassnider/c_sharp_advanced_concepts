namespace ObjectOrientedProgramming.Business
{
    public class Service : ISalable
    {
        private decimal _price;
        private decimal _tax;

        public Service(decimal price, decimal tax)
        {
            _price = price;
            _tax = tax;
        }

        public decimal GetPrice()
        {
            return _price + _tax;
        }
    }
}

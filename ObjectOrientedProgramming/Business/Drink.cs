namespace ObjectOrientedProgramming.Business
{
    public abstract class Drink
    {
        public int Quantity { get; set; }
        protected Drink(int quantity)
        {
            Quantity = quantity;
        }

        public string GetQuantity()
        {
            return $"Quantity: {Quantity}";
        }

        public abstract string GetCategory();
    }
}

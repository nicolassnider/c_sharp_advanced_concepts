namespace ObjectOrientedProgramming.Business
{
    public class Beer : Drink, ISalable, ISend
    {
        private const string Category = "Beer";
        public string Name { get; set; }
        public decimal Price { get; set; }

        public static int QuantityObjects;

        private decimal _alcohol;

        public decimal Alcohol
        {
            get => _alcohol;
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _alcohol = value;
            }
        }

        public Beer(string name, decimal price, decimal alcohol, int quantity) : base(quantity)
        {
            Name = name;
            Price = price;
            Alcohol = alcohol;
            QuantityObjects++;

        }

        public string GetInfo() => $"{Name} costs {Price:C}, alcohol {Alcohol}%";
        public virtual string GetInfo(string message)
        {
            return $"{message} {Name} costs {Price:C}, alcohol {Alcohol}%";
        }

        public override string GetCategory()
        {
            return Category;
        }

        public decimal GetPrice()
        {
            return Price;
        }

        public void Send()
        {
            Console.WriteLine($"Sending {GetInfo()}");
        }
    }
}

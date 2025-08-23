namespace ObjectOrientedProgramming.Business
{
    public class ExpiringBeer : Beer
    {
        public DateTime Expiration { get; set; }
        public ExpiringBeer(string name, decimal price, int alcohol, int quantity, DateTime expiration) : base(name, price, alcohol, quantity)
        {
            Expiration = expiration; // Default expiration date set to 30 days from now
        }

        public override string GetInfo(string message)
        {
            return base.GetInfo("override " + message);
        }
    }
}

namespace ObjectOrientedProgramming.Business
{
    public class Wine : Drink
    {
        public Wine(int quantity) : base(quantity)
        {
        }

        public override string GetCategory() => "Wine";
    }
}

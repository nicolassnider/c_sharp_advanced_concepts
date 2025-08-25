using ExtensionMethods.Classes;

namespace ExtensionMethods.Extensions
{
    public static class BeerExtensions
    {
        public static Beer SetQuantity(this Beer beer, decimal Quantity)
        {
            beer.Quantity = Quantity;
            return beer;
        }

        public static Beer SetName(this Beer beer, string Name)
        {
            beer.Name = Name;
            return beer;
        }
        public static Beer SetBrand(this Beer beer, string brand)
        {
            beer.Brand = brand.ToUpper();
            return beer;
        }
    }
}

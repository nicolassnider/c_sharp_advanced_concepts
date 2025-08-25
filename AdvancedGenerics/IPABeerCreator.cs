namespace AdvancedGenerics
{
    public class IPABeerCreator : IDrinkCreator<Beer>
    {
        public Beer Create(double quantity) => new Beer("IPA", (int)quantity);

    }
}

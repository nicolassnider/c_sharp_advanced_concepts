namespace AdvancedGenerics.Interfaces
{
    public interface IDrinkCreator<out T>
    {
        T Create(double quantity);
    }
}

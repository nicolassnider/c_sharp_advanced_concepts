namespace AdvancedGenerics
{
    public interface IDrinkCreator<out T>
    {
        T Create(double quantity);
    }
}

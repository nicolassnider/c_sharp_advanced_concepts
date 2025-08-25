namespace AdvancedGenerics.Interfaces
{
    public interface IShow<in T>
    {
        public void Show(T element);
    }
}

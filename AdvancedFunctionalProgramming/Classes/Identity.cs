using AdvancedFunctionalProgramming.Interfaces;

namespace AdvancedFunctionalProgramming.Classes
{
    public class Identity<T> : IFunctor<T>
    {
        private readonly T _value;

        public Identity(T value)
        {
            _value = value;
        }

        public T GetValue()
        {
            throw new NotImplementedException();
        }

        public IFunctor<TResult> Map<TResult>(Func<T, TResult> fn)
            => new Identity<TResult>(fn(_value));
    }
}

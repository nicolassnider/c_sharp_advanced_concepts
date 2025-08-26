using AdvancedFunctionalProgramming.Interfaces;

namespace AdvancedFunctionalProgramming.Classes
{
    public class MaybeFunctor<T> : IFunctor<T>
    {

        private readonly T _value;
        private readonly bool _hasValue;

        public MaybeFunctor(T value, bool hasValue)
        {
            _value = value;
            _hasValue = hasValue;
        }

        public static MaybeFunctor<T> Some(T value)
        {
            return new MaybeFunctor<T>(value, true);
        }

        public static MaybeFunctor<T> None()
        {
            return new MaybeFunctor<T>(default(T), false);
        }

        public IFunctor<TResult> Map<TResult>(Func<T, TResult> fn)
        {
            if (!_hasValue)
            {
                return MaybeFunctor<TResult>.None();
            }
            return MaybeFunctor<TResult>.Some(fn(_value));
        }

        public T GetValue()
        {
            throw new NotImplementedException();
        }

    }
}

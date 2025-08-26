using AdvancedFunctionalProgramming.Interfaces;

namespace AdvancedFunctionalProgramming.Classes
{
    public class MaybeMonad<T> : IFunctor<T>
    {

        private readonly T _value;
        private readonly bool _hasValue;

        public MaybeMonad(T value, bool hasValue)
        {
            _value = value;
            _hasValue = hasValue;
        }

        public static MaybeMonad<T> Some(T value)
        {
            return new MaybeMonad<T>(value, true);
        }

        public static MaybeMonad<T> None()
        {
            return new MaybeMonad<T>(default(T), false);
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

        public MaybeMonad<TResult> Bind<TResult>(Func<T, MaybeMonad<TResult>> binder)
        {
            if (!_hasValue)
            {
                return MaybeMonad<TResult>.None();
            }
            return binder(_value);
        }

    }
}

namespace AdvancedFunctionalProgramming.Extensions
{
    public static class ListExtensions
    {
        public static List<TOutput> Map<TInput, TOutput>(this List<TInput> list, Func<TInput, TOutput> fn)
        {
            List<TOutput> lstResult = new List<TOutput>();

            foreach (TInput item in list)
            {
                TOutput result = fn(item);
                lstResult.Add(result);
            }

            return lstResult;
        }

        public static List<T> Filter<T>(this List<T> lst, Func<T, bool> fn)
        {
            List<T> lstResult = new List<T>();

            foreach (T item in lst)
            {
                if (fn(item))
                {
                    lstResult.Add(item);
                }
            }
            return lstResult;
        }

        public static TOutput Reduce<TInput, TOutput>(this List<TInput> lst, Func<TOutput, TInput, TOutput> fn, TOutput initialValue)
        {
            TOutput accumulator = initialValue;

            foreach (TInput item in lst)
            {
                accumulator = fn(accumulator, item);
            }

            return accumulator;
        }
    }
}

namespace ExtensionMethods.Extensions
{
    public static class ListExtensions
    {
        public static bool Exists<T>(this T elementt, List<T> list)
        {
            foreach (T item in list)
            {
                if (item.Equals(elementt))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsOn<T>(this T elementt, List<T> list) where T : class
        {
            foreach (T item in list)
            {
                if (item.Equals(elementt))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

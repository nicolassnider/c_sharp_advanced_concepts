namespace AdvancedFunctionalProgramming.Classes
{
    public static class Memoization
    {
        public static Func<double, double> Pow(double pow)
        {
            var cache = new Dictionary<double, double>();
            return (number) =>
            {
                if (cache.ContainsKey(number))
                {
                    Console.WriteLine("Fetching from cache");
                    return cache[number];
                }
                else
                {
                    Console.WriteLine("Calculating result");
                    double result = Math.Pow(number, pow);
                    cache[number] = result;
                    return result;
                }
            };
        }

        public static Func<int, Task<string>> GetUrl(string url)
        {
            var cache = new Dictionary<int, string>();
            return async (id) =>
            {
                if (cache.ContainsKey(id))
                {
                    Console.WriteLine("Fetching from cache");
                    return cache[id];
                }
                else
                {
                    Console.WriteLine("Fetching from web");
                    using HttpClient client = new HttpClient();
                    string result = await client.GetStringAsync($"{url}/{id}");
                    cache[id] = result;
                    return result;
                }
            };
        }

        public static Func<TInput, TOutput> Mem<TInput, TOutput>(Func<TInput, TOutput> fn)
        {
            var cache = new Dictionary<TInput, TOutput>();

            return (key) =>
            {
                if (cache.ContainsKey(key))
                {
                    Console.WriteLine("Fetching from cache");
                    return cache[key];
                }
                else
                {
                    Console.WriteLine("Calculating result");
                    TOutput result = fn(key);
                    cache[key] = result;
                    return result;
                }
            };
        }

        public static Func<TInput, Task<TOutput>> MemAsync<TInput, TOutput>(Func<TInput, Task<TOutput>> fn)
        {
            var cache = new Dictionary<TInput, TOutput>();
            return async (key) =>
            {
                if (cache.ContainsKey(key))
                {
                    Console.WriteLine("Fetching from cache");
                    return cache[key];
                }
                else
                {
                    Console.WriteLine("Calculating result");
                    TOutput result = await fn(key);
                    cache[key] = result;
                    return result;
                }
            };
        }

    }
}

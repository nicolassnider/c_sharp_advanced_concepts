namespace AdvancedFunctionalProgramming.Classes
{
    public static class Closure
    {
        public static Func<int, int, int> SumClosure()
        {
            int i = 0;
            return (a, b) =>
            {
                i++;
                Console.WriteLine(i);
                return a + b;
            };
        }

        public static Action DelayExecutor(int time, Action fn)
        {
            return () =>
            {
                Console.WriteLine("Before Delay");
                System.Threading.Thread.Sleep(time);
                fn();
                Console.WriteLine("After Delay");

            };
        }
    }
}

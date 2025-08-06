namespace mssa_5._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3; // Example input
            int ways = ClimbStairs(n);
            Console.WriteLine($"Distinct ways to climb {n} steps: {ways}");
        }

        /// Returns the number of distinct ways to climb to the top
        static int ClimbStairs(int n)
        {
            if (n <= 2) return n;

            int first = 1, second = 2;
            for (int i = 3; i <= n; i++)
            {
                int current = first + second;
                first = second;
                second = current;
            }
            return second;
        }
    }
}

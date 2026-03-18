using System.Runtime.InteropServices;

public class Program
{
    public static void Main(string[] args)
    {
        int n = 4;
        PrintNumbersFramePattern(n);

    }

    private static void PrintNumbersFramePattern(int n)
    {
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < i; j++ )
            {
                Console.Write($"{n - j} ");
            }

            for(int k = 0; k < 2 * (n - i) - 1; k++)
            {
                Console.Write($"{n - i} ");
            }

            for(int l = i; l > 0; l--)
            {
                Console.Write($"{ n - l + 1 } ");
            }
            Console.WriteLine();
        }

        for(int m = n - 2; m >= 0; m--)
        {
            for(int o = 0; o < m; o++)
            {
                Console.Write($"{n - o} ");
            }

            for(int p = 0; p < 2 * (n - m) - 1; p++)
            {
                Console.Write($"{n - m} ");
            }

            for (int q = m; q >= 1; q--)
            {
                Console.Write($"{n - q + 1} ");
            }
            Console.WriteLine();
        }
    }
}
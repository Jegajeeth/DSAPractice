
public class Program
{
    public static int SumOfNumbers(int number)
    {
        Console.WriteLine($"number is {number}");
        if (number == 0)
        {
            return 0;
        }

        return number + SumOfNumbers(number - 1);
    }

    public static string PrintName(int n)
    {
        if (n == 0)
        {
            return "Jeethu";
        }

        Console.WriteLine($"Count: {n}");
        return PrintName(n - 1);
    }

    public static void PrintName(int count, int n)
    {
        if (count == n)
        {
            return;
        }

        Console.WriteLine($"Hello, {count}");
        PrintName(count + 1, n);
    }

    public static void CountDownNumbers(int n)
    {
        if (n == 0)
        {
            return;
        }
        Console.WriteLine("Counrting down: {0}", n);

        CountDownNumbers(n - 1);
    }

    public static void CountUpNumbers(int n)
    {
        if (n == 0)
        {
            return;
        }

        CountUpNumbers(n - 1);

        Console.WriteLine("Counting Up: {0}", n);
    }

    public static int SumToN(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        return n + SumToN(n - 1);
    }

    public static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        return n * Factorial(n - 1);
    }

    public static int Power(int x, int n)
    {
        if (n == 1)
        {
            return x;
        }

        return x * Power(x, n - 1);
    }

    public static int Multiply(int a, int b)
    {
        if (b == 1)
        {
            return a;
        }

        return a + Multiply(a, b - 1);
    }

    public static int CountDigits(int d)
    {
        if (d == 0)
        {
            return 0;
        }

        int count = 1;

        int previousCount = CountDigits(d / 10);

        return count + previousCount;
    }

    public static int SumOfDigits(int d)
    {
        if (d == 0)
        {
            return d;
        }

        int digit = d % 10;

        return digit + SumOfDigits(d / 10);
    }

    public static int SumArray(int[] number, int startIndex = 0)
    {
        if (number.Length == 0)
        {
            return 0;
        }
        if (startIndex == (number.Length - 1))
        {
            return number[startIndex];
        }

        int ele = number[startIndex];

        return ele + SumArray(number, startIndex + 1);
    }

    public static int FindMax(int[] numbers, int startIndex = 0)
    {
        if (numbers.Length == 0 || startIndex >= numbers.Length)
        {
            return 0;
        }
        if (startIndex == numbers.Length - 1)
        {
            return numbers[startIndex];
        }

        int max = numbers[startIndex];

        int previousMax = FindMax(numbers, startIndex + 1);

        if (previousMax < max)
        {
            return max;
        }

        return previousMax;

    }

    public static void Main(string[] args)
    {
        int number = 48;
        Console.WriteLine("Print Name after counting to N: {0}", PrintName(number));
        PrintName(0, number);

        Console.WriteLine("result of summing array element is {0}", SumOfNumbers(number));

        CountDownNumbers(10);
        CountUpNumbers(10);

        Console.WriteLine("Sum Of N: {0}", SumToN(10));
        Console.WriteLine("Factorial Of N: {0}", Factorial(10));
        Console.WriteLine("Power Of X to N: {0}", Power(8, 5));
        Console.WriteLine("Multiply Of a X b: {0}", Multiply(10, 500));
        Console.WriteLine("Count Digits Of N: {0}",
        number > 0 ? CountDigits(number) : 1);
        Console.WriteLine("Sum of Digits Of N: {0}",
        number > 0 ? SumOfDigits(number) : 1);

        int[] numbers = [4, 5, 9, 7, 21, 3, 4];

        Console.WriteLine("Sum Of array ele: {0}", SumArray(numbers));
        Console.WriteLine("Factorial Of N: {0}", Factorial(10));
        Console.WriteLine("Max number of Array: {0}", FindMax(numbers));
    }
}
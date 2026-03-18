
public class Program
{
    public static void Main(string[] args)
    {
        int number = 6;
        // string result = PrintName(number);
        // PrintName(0, number);
        int result = SumOfNumbers(number);

        Console.WriteLine($"result is {result}");


    }

    public static int SumOfNumbers(int number)
    {
        Console.WriteLine($"number is {number}");
        if(number == 0)
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

        Console.WriteLine($"My name is {n}");
        return PrintName(n - 1);
    }

    public static void PrintName(int count, int n)
    {
        if(count == n)
        {
            return;
        }

        Console.WriteLine($"Hello, {count}");
        PrintName(count + 1, n);
    }
}
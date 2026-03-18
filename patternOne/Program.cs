
int n = 5;

// for (int i = 0; i <= n; i++)
// {
//     for(int j = 0; j <= n - 1 - i; j++)
//     {
//         Console.Write(" ");
//     }
//     for(int k = 0; k < 2 * i + 1; k ++ )
//     {
//         Console.Write("*");
//     }
//     for(int l = 0; l <= n - 1 - i; l++)
//     {
//         Console.Write(" ");
//     }
//     Console.WriteLine();
// }

for (int i = n-1; i >= 0; i--)
{
    for (int j = 1; j < i + 2; j++)
    {
        Console.Write(j);
    }
    for (int k = 0; k < (n - i - 1) * 2; k++)
    {
        Console.Write(" ");
    }
    for (int l = i + 1; l > 0; l--)
    {
        Console.Write(l);
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    for(int j = 1; j < i+2 ; j++)
    {
        Console.Write(j);
    }
    for (int k = 0; k < (n -i - 1) * 2; k++)
    {
        Console.Write(" ");
    }
    for (int l = i+1; l > 0; l--)
    {
        Console.Write(l);
    }
    Console.WriteLine();
}

int n = 102301;

if(n < 0)
{
    Console.WriteLine("Not a palindrome");
}
else
{
    int temp = n;
    int rev = 0;
    while(temp != 0)
    {
        int rem = temp % 10;
        rev = rev * 10 + rem;
        temp /= 10;
    }
    if(rev == n)
        Console.WriteLine("Palindrome");
    else
        Console.WriteLine("Not a palindrome");
}
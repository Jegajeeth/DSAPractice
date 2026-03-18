int x = 1534236469;
int modValue = 0;
int reversedNumber = 0;
bool isNegativeNumber = false;
if (x < 0)
{
    isNegativeNumber = true;
}

while (x != 0)
{
    modValue = x % 10;
    x /= 10;
    if (reversedNumber > int.MaxValue / 10 || reversedNumber < int.MinValue / 10)
    {
        Console.Write(0);
        break;
    }
    reversedNumber = (reversedNumber * 10) + modValue;
}

reversedNumber =
    isNegativeNumber && reversedNumber > 0 ?
        reversedNumber * -1 : reversedNumber;

Console.Write(reversedNumber);
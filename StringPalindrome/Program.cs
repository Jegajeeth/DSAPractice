
string s = "A man, a plan, a canal: Panama";
int stringLength = s.Length - 1;

string reversedString = string.Empty;
string lettersOnlyString = string.Empty;

while(!(stringLength < 0))
{
    char stringElement = s.ElementAt(stringLength);
    if(!char.IsLetterOrDigit(stringElement) || char.IsWhiteSpace(stringElement))
    {
        stringLength -= 1;
        continue;
    }

    stringElement = char.ToLower(stringElement);

    reversedString += stringElement;
    lettersOnlyString = stringElement + lettersOnlyString;
    if(!reversedString.Equals(lettersOnlyString))
    {
        Console.WriteLine($"Not a paliandrome. {reversedString}, {lettersOnlyString}");
    }
    stringLength -= 1;
}


Console.WriteLine($"reversed string {reversedString}");
Console.WriteLine($"letters only string: {lettersOnlyString}");

// See https://aka.ms/new-console-template for more informatio

int RemoveSecondDigit(int number)
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
    return firstDigit * 10 + secondDigit;
}
int removeSecondDigit = RemoveSecondDigit (num);
Console.Write(removeSecondDigit);
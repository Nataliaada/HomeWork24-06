


int rndNum = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 -99 => {rndNum}");
int MaxDigit(int num)
{
int firstDigit = num / 10;
int secondDigit = num % 10;
if (firstDigit == secondDigit) return 0;
return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit =  MaxDigit(rndNum);
string result = maxDigit > 0 ? maxDigit.ToString() : "цИФРЫ ОДИНАКОВЫЕ";
Console.WriteLine($"Наибольшая цифра числа {rndNum} => {result}");

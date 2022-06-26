// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5 782 -> 8 918 -> 1




Console.WriteLine("Введите трехзначное число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 1000 && a > 99)
{
int SecondDigit(int num)
{
int res = num / 10;
int res1 = res % 10;
return res1;
}

int secondDigit = SecondDigit(a);
int result = secondDigit;
Console.WriteLine($"Вторая цифра числа {a} => {result}");
}
else Console.WriteLine($"Это не трехзначное число");

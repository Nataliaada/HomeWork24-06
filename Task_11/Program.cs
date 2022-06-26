// Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int rndNum = new Random().Next(99, 1000);
Console.WriteLine($"Случайное число из отрезка 10 -99 => {rndNum}");

int RemoveSecondDigit(int num)
{
int firstDigit = num / 100;
int secondDigit = num % 10;
return firstDigit * 10 + secondDigit;
}
int removeSecondDigit =  RemoveSecondDigit(rndNum);
Console.WriteLine(removeSecondDigit);

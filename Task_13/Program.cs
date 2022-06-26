
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());


int res = num1 / 100;
int res2 = num1 % 23;

if (res == 0 & res2 == 0)
{
Console.WriteLine($"Число кратно 7 и 23 ");
}
else
{
    Console.WriteLine($"Число Не кратно 7 и 23");
}

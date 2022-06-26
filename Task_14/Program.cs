//Задача 14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 46 -> нет 161 -> да

Console.WriteLine("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());

int res = num1 % 7;
int res2 = num1 % 23;

if (res == 0 & res2 == 0)
{
Console.WriteLine($"Число кратно 7 и 23 ");
}
else
{
    Console.WriteLine($"Число Не кратно 7 и 23");
}

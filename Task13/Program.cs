
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5  78 -> третьей цифры нет 32679 -> 6


Console.WriteLine("ВВедите число");
int num = Convert.ToInt32(Console.ReadLine());
string numtext = Convert.ToString(num);
if (numtext.Length > 2)
{
    Console.WriteLine($"Третья цифра = " + numtext[2]);
}
else Console.WriteLine("Третья цифра отсутствует"); 
//Задача 12: Напишите программу, которая принимает на вход 2 числa и выводит является ли второе кратно первому . 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления




Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

int res = a%b;

if (res == 0) 
{
    Console.WriteLine($"Второе число кратно первому");
}
else
Console.WriteLine($"некратно, остаток от деления равен {res}");



// Console.WriteLine("Введите число ");
// int num1 = Convert.ToInt32(Console.Readline());
// Console.WriteLine("Введите число ");
// int num2 = Convert.ToInt32(Console.Readline());
// int res = num1 + num2;

// if (res == 0)
// {
//   Console.WriteLine("кратно");  
// }
// else
// {
//     Console.WriteLine("некратно");  
// }
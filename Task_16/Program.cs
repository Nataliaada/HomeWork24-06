// Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да -4, 16 -> да 25, 5 -> да ,9 -> нет



Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

int res = a * a;
int res2 = b * b;

if (res == b ) 
   Console.WriteLine($"Первое число является квадратом второго");

   else if  (a == res2) Console.WriteLine($"Второе число является квадратом превого");

else Console.WriteLine("Ни одно число не является квадратом другого");




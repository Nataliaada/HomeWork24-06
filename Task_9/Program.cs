// 2. Напишите программу, которая выводит 
// случайное число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8


int rndNum = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 -99 => {rndNum}");


// первый вариант:
// int firstDigit = rndNum / 10;
// int secondDigit = rndNum % 10;
// Console.Write($"Наибольшая цифра числа {rndNum}=>");

// // if (firstDigit > secondDigit) Console.WriteLine (firstDigit);
// // else Console.WriteLine (secondDigit);
//либо
// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine(result);

int MaxDigit(int num)
{

int firstDigit = num / 10;
int secondDigit = num % 10;
if (firstDigit == secondDigit) return 0;
return firstDigit > secondDigit ? firstDigit : secondDigit;

}
int maxDigit =  MaxDigit(rndNum);
string result = maxDigit > 0 ? maxDigit.ToString() : "цифры одинаковые";
Console.WriteLine($"Наибольшая цифра числа {rndNum} => {result}");








// int rndNum2 = new Random().Next(10, 100);
// int rndNum3 = new Random().Next(10, 100);

// int rndNum = new Random();
// while(true)
// {

//     int rndNum3 = new Random();
// }

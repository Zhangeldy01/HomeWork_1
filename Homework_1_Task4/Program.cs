/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Введите три числа: ");
string str1 = Console.ReadLine()??"";
int a = Convert.ToInt32(str1);
string str2 = Console.ReadLine()??"";
int b = Convert.ToInt32(str2);
string str3 = Console.ReadLine()??"";
 int c = Convert.ToInt32(str3);
 int max = a;
if (b > max)
{
 max = b;
}
if (c > max)
{
max = c;
}
 Console.WriteLine($"max = {max}");
Console.ReadLine();


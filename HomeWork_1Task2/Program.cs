/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

 
Console.WriteLine("Введите два числа: ");
string str1 = Console.ReadLine()??"";
int a = Convert.ToInt32(str1);
string str2 = Console.ReadLine()??"";
int b = Convert.ToInt32(str2);
 
if (a > b)
 
{
   Console.WriteLine($"{a} - наибольшее число");
}
else
{
   Console.WriteLine($"{b} - наибольшее число");
}
 
Console.ReadLine();
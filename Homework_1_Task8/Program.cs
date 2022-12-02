/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
 Console.WriteLine("Введите число: ");
 string str = Console.ReadLine()??"";
 int N = Convert.ToInt32(str);

 int a = 2;
 int i = 0;

 while (i < N)
 {
    Console.WriteLine($"{a} - четное число");
    a = a +2;
    i = i + 2;
 }
Console.ReadLine();

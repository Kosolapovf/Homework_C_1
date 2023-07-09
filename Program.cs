/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = number % 2;
if (i == 0)
    Console.Write($"{number} - четное");
else
    Console.Write($"{number} - нечетное");    


//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("First number ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Second number ");
int num1 = int.Parse(Console.ReadLine()!);

int max = num1;
int min = num;

if (num > max) num = max;
if (num1 < min) num1 = min;


Console.Write("max = ");
Console.WriteLine(num1);
Console.Write("min = ");
Console.WriteLine(num);
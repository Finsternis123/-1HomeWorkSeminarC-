// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("First number ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Second number ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Third number ");
int c = int.Parse(Console.ReadLine()!);

int max = a;

if (a > max ) max = a;
if (b > max ) max = b;
if (c > max ) max = c;

Console.Write("max = ");
Console.WriteLine(max);
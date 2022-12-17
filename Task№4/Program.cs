// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Enter number ");
int num = int.Parse(Console.ReadLine()!);

int a = 1;

while(a <= num){
    if ((a % 2) == 0)
    Console.Write($"{a} ");
    a++;
}
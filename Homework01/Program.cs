// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого 
//числа
Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int a1 = num % 100; // 230%100=30
int a2 = a1 / 10; 


Console.WriteLine($"Трехзначное число {num} -> {a2}");

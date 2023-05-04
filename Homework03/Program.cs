// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и поверяет, является ли
// этот день выходным.
Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if (num < 6)
{
    Console.WriteLine($"{num} -> нет");
}
else
{
Console.WriteLine($"{num} -> да");
}
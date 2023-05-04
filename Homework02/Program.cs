// Напишите программу, которая выводит третью цифру заданного или сообщает, что третьей цифры нет.
Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);


if(num < 100)
{
    Console.WriteLine("нет третьей цифры");
}
else
{
    int a1 = num % 1000;   
    int a2 = a1 / 100;
    Console.WriteLine($"Трехзначное число {num} -> {a2}");
}
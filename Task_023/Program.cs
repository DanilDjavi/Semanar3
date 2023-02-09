// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
String Str = ": ";
if(int.TryParse(Console.ReadLine(), out int number))
{
    for(int i=1; i != number+1; i++)
    {
        Str=Str+ Math.Pow(i, 3) + "; ";
    }
}
else Console.WriteLine("Ошибка");
Console.Write($"Ряд кубов чисел от 1 до {number}");
Console.WriteLine(Str);

// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
if(int.TryParse(Console.ReadLine(), out int number))
{
    int num =(int)Math.Log10(Math.Abs(number)) + 1;
    if (num != 5 ) Console.WriteLine("Введено не пятизначное число");
}
else Console.WriteLine("Введите целое число");
int newNumber = 0;
int doubleNumber = number;
for(int i=5; i != 0; i--) 
{
    newNumber = newNumber * 10;
    newNumber = newNumber + (doubleNumber % 10);
    doubleNumber = doubleNumber / 10;    
}
if (number != newNumber)
{
    Console.WriteLine("Не является палиндромом");
}
else Console.WriteLine("Является палиндромом");
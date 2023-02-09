//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int[] arrayA = new int[3];
int[] arrayB = new int[3];
void coordInput(string a) 
{
    Console.Write($"Введите значение X для точки {a} : "); 
    if(int.TryParse(Console.ReadLine(), out int x))
    {
        switch(a)
        {
            case "A":
                arrayA[0] = x;
                break;
            case "B":
                arrayB[0] = x;
                break;
            default:
                Console.WriteLine("Неверное значение");
                break;
        }
    }
    else Console.WriteLine("Ошибка");
    Console.Write($"Введите значение Y для точки {a} : ");
    if(int.TryParse(Console.ReadLine(), out int y))
    {
        switch(a)
        {
            case "A":
                arrayA[1] = y;
                break;
            case "B":
                arrayB[1] = y;
                break;
            default:
                Console.WriteLine("Неверное значение");
                break;
        }
    }
    else Console.WriteLine("Ошибка");
    Console.Write($"Введите значение Z для точки {a} : ");
    if(int.TryParse(Console.ReadLine(), out int z))
    {
        switch(a)
        {
            case "A":
                arrayA[2] = z;
                break;
            case "B":
                arrayB[2] = z;
                break;
            default:
                Console.WriteLine("Неверное значение");
                break;
        }
        
    }
    else Console.WriteLine("Ошибка");
}
coordInput("A");
coordInput("B");
Console.WriteLine($"A: ({arrayA[0]} , {arrayA[1]} , {arrayA[2]})");
Console.WriteLine($"B: ({arrayB[0]} , {arrayB[1]} , {arrayB[2]})");
double distance = Math.Sqrt(Math.Pow((arrayA[0]-arrayB[0]),2)+Math.Pow((arrayA[1]-arrayB[1]),2)+Math.Pow((arrayA[2]-arrayB[2]),2));
distance=Math.Round(distance, 2);
Console.WriteLine($"Расстояние между точками равен: {distance}");
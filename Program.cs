/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
#region 
int InputNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] GetArray(int size)
{
    return new int[size];
}

void GetNumber(int[] array)
{
    int min = -1000;
    int max = 1000;
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max);
}

void PrintArr(int[] array)
{
    Console.WriteLine($" Массив: [{string.Join("| ", array)}.]");
}

int NumbersGreaterThanZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    
        if(array[i] > 0)
            count++;
            
    return count;
}

int num = InputNumber(" Введите количество чисел: ");
int[] arr = GetArray(num);
GetNumber(arr);
PrintArr(arr);
int greaZero = NumbersGreaterThanZero(arr);
Console.WriteLine(" Количество чисел больше нуля: " + greaZero);
#endregion
/*
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
*/
#region 
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void PointOfIntersection(double b1, double k1, double b2, double k2)
{
    double x = (-b2 + b1)/(-k1 + k2);
    double y = k2 * x + b2;
    Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}

double b1 = InputNum(" Введите значения b1:  ");
double k1 = InputNum(" Введите значения k1:  ");
double b2 = InputNum(" Введите значения b2:  ");
double k2 = InputNum(" Введите значения k2:  ");
PointOfIntersection(b1, k1, b2, k2);
#endregion
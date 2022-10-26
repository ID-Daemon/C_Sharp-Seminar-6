// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//кол-во цифр (M)
int size = 3;

int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите значение №{i}: ");
    array[i] = int.Parse(Console.ReadLine()!);
}
Console.WriteLine();
Console.WriteLine($"Вы ввели {CountNumberMoreZero(array)} чисел больше 0");

int CountNumberMoreZero (int[] collection){
    int count = 0;
    foreach (int item in collection)
    {
        if (item>0) count++;
    }
    return count;
}


Console.WriteLine();
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine()!);
double x = (b2-b1)/(k1-k2);
double result1 = k1 * x + b1;
double result2 = k2 * x + b2;

Console.WriteLine();
Console.WriteLine($"({result1:f2}; {result2:f2})");

//Доп.Задача (Если вдруг не можете решить 43, либо хотите решить для интереса)
// Найти произведение всех элементов массива целых чисел, меньших заданного числа. Размерность массива – 10. Заполнение массива осуществить случайными числами от 50 до 100.
Console.WriteLine();
Console.WriteLine();

size = 10;
int[] arr = new int[size];
GetArray(arr, 50, 100);
Console.WriteLine("Введите число: ");
int xNumber = int.Parse(Console.ReadLine()!);
int sum = FindXCount(arr, xNumber);
if (sum>1) Console.WriteLine("Произведение всех элементов массива целых чисел, меньших заданного числа равна - " + sum);
else Console.WriteLine("В массиве не найдего элементов меньше заданного числа");


int[] GetArray(int[] collection, int minValue, int maxValue){
    for (int i = 0; i < collection.Length; i++) {
        collection[i] = new Random().Next(minValue, maxValue+1);
    }
    return collection;
}

int FindXCount(int[] collection, int x){
    int sum=1;
    foreach (int item in collection)
    {
        if (item<x) sum*=item;
    }
    return sum;
}
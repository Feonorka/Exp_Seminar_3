// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];

// int array[] =  new int[8]{4, 8, 4, 6, 7, 4, 1, 0};
// int array[] = {4, 8, 4, 6, 7, 4, 1, 0};
void ArrAdd(int[] arr)
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
}
}
ArrAdd(array);
Console.WriteLine(array); 

int[] arrayGlobal = new int[num];

FillArrayRandom(arrayGlobal);
PrintArray(arrayGlobal);

void FillArrayRandom(int[] array)
{
Random rnd = new Random();
for (int i = 0; i <= array.Length - 1; i++)
array[i] = rnd.Next(0, 2);
}

void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
Console.Write($"{array[array.Length - 1]}]");
}
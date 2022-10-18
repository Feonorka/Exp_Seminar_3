// 1. Задает массив из 8 элементов
// 2. Выводит их на экран

Console.WriteLine("Введите количество элементов массива:");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        if (i == count - 1) Console.Write($"{arr[i]} ");
        else Console.Write($"{arr[i]}, ");
        
    }
    
}

void FillArray(int[] col)
{
    int lenght = col.Length;
    int index = 0;
    while (index < lenght)
    {
        col[index] = new Random().Next(1, 100);
        index++;
    }
}

FillArray(array);
PrintArray(array);
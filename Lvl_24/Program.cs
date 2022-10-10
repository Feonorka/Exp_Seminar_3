// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SummNum(number);
Console.WriteLine($"Сумма всех чисел до {number} = {result}");

int SummNum(int num)
{
    int counter = 1;
    int summ = default;
    // for (int i = 1; i <= num; i++)
    // {
    //     summ = summ + i;   
    // }
    while (counter <= num)
    {
        summ += counter;
        counter++;
    }

    return summ;
}
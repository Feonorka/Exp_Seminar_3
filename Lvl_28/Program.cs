// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) Console.WriteLine("Введите заново");
else
{
int Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
int res = default;
for (int i = 1; i <= number; i++)
{
    res = Factorial(i);
}
Console.WriteLine($"{number}! = {res}");


int FactNum(int num)
{
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial *= i;   
    }
return factorial;
}
int result = FactNum(number);
Console.WriteLine($"Факториал всех чисел до {number} = {result}");
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

int MakeDeegree(int num, int degree)
{
if (degree == 0) return 1;
for (int i = 1; i <= degree; i++)
    {
        number = number * i;
    }
    return number;
}

int res = MakeDeegree(number, degree);
Console.WriteLine($"Число {number} в степени {degree} равно {res}");
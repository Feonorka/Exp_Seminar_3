Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

int NumCounter(int number)
{
int res = default;
while (number !=0)
{
res++;
number = number / 10;
}
return res;
}

int NumSumm(int intNum)
{
int res = default;
for (int i = 0; i <= NumCounter(num); i++)
{
res = res + (intNum % 10);
intNum = intNum / 10;
}
return res;
}
int result = NumSumm(num);
Console.WriteLine($"Сумма цифр в числе = {result}");

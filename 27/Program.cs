// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (a>0)
{
    int k = a % 10;
    sum += k;
    a /= 10;
}
Console.WriteLine("сумма цифр равна " + sum);
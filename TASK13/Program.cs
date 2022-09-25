Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n > 1000)
{
    n = n / 10;
Console.WriteLine($"Третья цифра числа: {n % 10}");
}
if (n < 100)
Console.WriteLine("Третьей цифры нет");

Console.Write("Введите день недели(1-7): ");
int n = Convert.ToInt32(Console.ReadLine());
while (n<1 || n>7)
{
    Console.Write("пробуй снова: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n <=5)
    Console.WriteLine("нет");
if(n>5)
    Console.WriteLine("да");
Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

int i = 1;

if (a < 0)
{
    a = (a * (-1));
}
if (a > 0)
{
    while (a >= i)
    {
        Console.WriteLine(Math.Pow(i, 2));
        i++;
    }
}

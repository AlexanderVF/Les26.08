Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

int i = 1;
Console.Write(a + " -> ");
if (a < 0)
{
    a = (a * (-1));
}
if (a > 0)
{
        while (a >= i)
    {
        Console.Write(Math.Pow(i, 3) + ", ");
        i++;
    }
}


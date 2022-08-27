Console.Clear();
Console.WriteLine("Введите пятизначное число");
int a = int.Parse(Console.ReadLine());


while (a<10000 || a>99999)
{
    Console.WriteLine("Введите положительное пятизначное число");
    a = int.Parse(Console.ReadLine());
}

int b = a / 10000;
int c = (a / 1000) % 10;
int d = (a / 100) % 10;
int e = (a / 10) % 10;
int f = a % 10;

if (b == f && c == e)
{
    Console.WriteLine(a + " -> Это палиндром");
}
else 
{
    Console.WriteLine(a + " -> Это не палиндром");
}
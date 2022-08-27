Console.WriteLine("Введите X1");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y1");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите X2");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y2");
int y2 = int.Parse(Console.ReadLine());


//Math.Sqrt(Math.Pow(x1-x2) + Math.Pow(y1 - y2));

//Console.WriteLine(Math.Sqrt((x1-x2)*(x1-x2) + (y1 - y2)*(y1 - y2)));

Console.WriteLine(Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1 - y2, 2)));
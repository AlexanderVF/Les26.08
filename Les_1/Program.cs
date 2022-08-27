//void chetverti (int chetverti) {
  //  Console.WriteLine("Дипазон координат");

Console.WriteLine("Введите номер четверти");
int c = int.Parse(Console.ReadLine());

while (c <0 || c > 4) 
{
    Console.WriteLine("Введите номер четверти от 1 до 4");
    c = int.Parse(Console.ReadLine());
}

if (c == 1) 
{
    Console.WriteLine("Координаты x>0, y>0");
}
if (c == 2) {
    Console.WriteLine("Координаты x<0, y>0");
}
if (c == 3) {
    Console.WriteLine("Координаты x<0, y<0");
}
if (c == 4) {
    Console.WriteLine("Координаты x>0, y<0");
}
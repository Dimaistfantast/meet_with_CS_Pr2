Console.Write("Введите A = ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите B = ");
int b = int.Parse(Console.ReadLine()!);

if ((a == Convert.ToInt32(Math.Pow(b, 2))) || (b == Convert.ToInt32(Math.Pow(a, 2))) )
{
    Console.WriteLine("Числа являются квадратами друг друга");
}
else Console.WriteLine("Числа НЕ являются квадратами друг друга");


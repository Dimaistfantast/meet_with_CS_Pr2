Console.Write("Введите делимое: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите делитель: ");
int del = int.Parse(Console.ReadLine()!);

if (num%del == 0) {
    Console.WriteLine("Кратно");
}
else {
    Console.Write($"Не кратно, остаток {num%del}");
}
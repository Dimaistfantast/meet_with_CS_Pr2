Console.Write("Введите чисто: ");
int a = int.Parse(Console.ReadLine()!);

if ((a>5) && (a<8)) Console.WriteLine("Это выходной");
if ((a>0) && (a<6)) Console.WriteLine("Это НЕ выходной");
if ((a>7) || (a<1)) Console.WriteLine("Ошибка");
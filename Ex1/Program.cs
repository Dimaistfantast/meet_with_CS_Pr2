//Console.Write("Введите число: ");
//int number = int.Parse(Console.ReadLine()!);


int num = new Random().Next(1000);
string NumStr = num.ToString();

if (NumStr.Length == 3)
{
    Console.WriteLine($"Число {num} без второй цифры {NumStr[0]}{NumStr[2]}");
}
else
{
     Console.WriteLine($"Число {num} не трехзначное");
}
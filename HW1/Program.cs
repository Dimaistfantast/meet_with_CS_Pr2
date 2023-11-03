int num = new Random().Next(1000);
string NumStr = num.ToString();

if (NumStr.Length == 3)
{
    Console.WriteLine($"Вторая цифра числа {num} - {NumStr[1]}");
}
else
{
     Console.WriteLine($"Число {num} не трехзначное");
}

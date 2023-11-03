int num = new Random().Next(1000000);
string NumStr = num.ToString();

if (NumStr.Length >= 3)
{
    Console.WriteLine($"Третья цифра в числе {num} - {NumStr[2]}");
}
else
{
     Console.WriteLine($"В числе {num} нет третьей цифры");
}

int num = new Random().Next(1000);
string NumStr = num.ToString();

int n = NumStr.Length;
int index = 0;
char max = NumStr[0];
while (index < n)
{
    if (max < NumStr[index])
    {
        max = NumStr[index];
    }
    index++;
}
Console.WriteLine($"Наибольшая цифра числа {num} является {max}");
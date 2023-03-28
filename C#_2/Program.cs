/*Напишите программу которая выводит третью цифру ззаданного числа
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
Console.Clear();
int Prompt(string num3)
{
    Console.WriteLine($"{num3}");
    return Convert.ToInt32(Console.ReadLine());
}
int num = Prompt ("Введите число: ");
int num1(int num)
{
    while(num > 999)
    {
        num /=10;
    }
    return num % 10;
}
bool check(int num)
{
    if (num < 100)
    return false;
    else return true;
}
if (check(num) != true)
Console.WriteLine("Третьей цифры нет");
else 
    {
    Console.WriteLine($"Третья цифра числа {num} является {num1(num)}");
    }
/*Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
string num2 = Convert.ToString(num3);
Console.WriteLine("Вторая цифра этого числа -> " + num2[1]);
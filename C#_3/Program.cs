/*Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день 
выходным.
6 -> да
7 -> да
1 -> нет*/
Console.Clear();
Console.Write("Введите цифру, обозначающую день недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());
void DayOfTheWeek(int dayNum) {
    if(dayNum == 6 || dayNum == 7){
        Console.WriteLine("(выходной) -> да");
    }
    else if (dayNum < 1 || dayNum > 7){
        Console.WriteLine("Ошибка, такого дня недели несуществует");
    }
    else Console.WriteLine("(не выходной) -> нет");
}
DayOfTheWeek(dayNum);
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

void DayWeek()
{
    Console.WriteLine("Введите число, обозначающее день недели:");
    int x = Convert.ToInt32(Console.ReadLine()) ;
    if (x >= 1 && x <= 5)
    {
        Console.WriteLine("нет");
    }
    if(x == 6 || x ==7)
    {
        Console.WriteLine("да");
    }
    if (x > 7)
    {
        Console.WriteLine("Введите число от 1 до 7, обозначающее день недели ");
    }
}
DayWeek();
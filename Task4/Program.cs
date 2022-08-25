void DayWeek()
{
    Console.WriteLine("Введите число, обозначающее день недели:");
    int x = Convert.ToInt32(Console.ReadLine()) ;
    if (x >= 1 && x <= 5)
    {
        Console.WriteLine("нет");
    }
    else
    {
        if (x == 6 || x == 7)
        {
            Console.WriteLine("да");
        }
        else
        {
            if (x == 0 || x > 7)
            {
                Console.WriteLine("Введите число от 1 до 7, обозначающее день недели ");
            }
        }
    }
    
}
DayWeek();
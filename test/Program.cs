string Ending()
{
    Console.WriteLine("Введите слово в именительном падеже:");
    string x = Console.ReadLine();
    Console.WriteLine("Введите число:");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n % 10 == 1 && n % 100 != 11)
    {
        Console.WriteLine($"Кол-во : {n} Слово: {x}");
    }
    else
    {
        if(n == 3 && n == 4 || n % 10 == 2 && n %100 !=12 || n % 10 == 3 && n % 100 != 13 || n % 10 == 4 && n % 100 != 14)
        {
            Console.WriteLine($" Кол-во : {n} Слово {x}a");
        }
        else
        {
            Console.WriteLine($" Кол-во: {n} Слово : {x}ов"); 
        }
    }
    return(x);

}

 Ending();
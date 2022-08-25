// Доп.задача

Console.WriteLine("Введите число программистов:");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 10 == 1 && n % 100 != 11)
{
    Console.WriteLine(n + " Программист");
}
else
{
    if(n % 10 == 2 && n %100 !=12 || n % 10 == 3 && n % 100 != 13 || n % 10 == 4 && n % 100 != 14)
    {
        Console.WriteLine(n + " Программиста");
    }
    else
    {
        Console.WriteLine(n + " Программистов"); 
    }
}
    


 

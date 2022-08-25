// Доп.задача

Console.WriteLine("Введите число программистов:");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 1 && n % 10 == 1)
{
    Console.WriteLine(n + " Программист");
}
else
{
    if (n == 11 && n % 100 == 11)
    {
        Console.WriteLine(n + " Программистов"); 
    }
}

if (n == 2 || n == 3 || n ==4 || n % 10 == 2 || n % 10 == 3 || n % 10 == 4)
{
    Console.WriteLine(n + " Программиста");
}
 else
{
    Console.WriteLine(n + " Программистов"); 
}

 

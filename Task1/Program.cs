// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

//void ShowSecondNumbwer()
//{
    //Console.WriteLine("Введите трехзначное число: ");
    //int x = Convert.ToInt32(Console.ReadLine());
    //if (x >= 100 && x < 1000)
    //{
        //int x1 = x /10 % 10 ;
       // Console.WriteLine(x1);
    //}
    //else
    //{
        //Console.WriteLine("Вы ввели не трехзначное число,введите именно трехзначное ");
    //}
//}
   
//ShowSecondNumbwer();

int ShowSecondNumbwer(int x)
{   
    int x1 = 0;
    if (x >= 100 && x < 1000)
    {
        x1 = x /10 % 10 ;
        Console.WriteLine(x1);   
    }
    else 
    {  
        Console.WriteLine("Вы ввели не трехзначное число,введите именно трехзначное ");
    }
    
    return(x1);    
}

ShowSecondNumbwer(432);

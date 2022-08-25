// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

void ThirdNumber()
{
   System.Console.WriteLine("Введите целое число: ");
   int x = Convert.ToInt32(Console.ReadLine());
   string y = x.ToString();
   if (x > 100)
   {
     Console.WriteLine(y[2]);
   }
   else
   {
    if (x < 100)
    {
        Console.WriteLine("третьей цифры нет");
    }
   }
}
ThirdNumber();
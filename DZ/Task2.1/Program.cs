// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine());

if ( num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine($"{num} кратное 7 и 23");
}
else 
{
    if ( num % 7== 0)
    {
       Console.WriteLine($"{num} кратное только 7"); 
    }
    else
    {
        if (num % 23 == 0)
        {
            Console.WriteLine($"{num} кратное только 23");
        }
        else
        {
            Console.WriteLine($"{num}  не кратное 7 или 23");
        }
    }
}
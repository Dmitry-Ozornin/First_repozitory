// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

while(true)
{
    Console.WriteLine("Введите число или q для выхода");
    string word = Console.ReadLine();
    if (word == "q") break;

    int n;
    if (int.TryParse(word, out n))
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /=10;
        }
        if (sum % 2 == 0) break;
        
    }
    else
    {
        Console.WriteLine("Введите число или q для выхода");
    }
}
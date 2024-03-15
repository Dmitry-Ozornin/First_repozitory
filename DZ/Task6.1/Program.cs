// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

string GetListNum(int n, int m)
{
    if (m > n)
    {
        if (m == n)
        {
            return Convert.ToString(n);
        }
        return n + " " + GetListNum(n + 1, m);
    }
    if (m == n)
    {
        return Convert.ToString(m);
    }
    return m + " " + GetListNum(n, m + 1);
}




Console.WriteLine("введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write($"{GetListNum(n, m)}");
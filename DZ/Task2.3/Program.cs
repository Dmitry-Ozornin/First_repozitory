//  Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.WriteLine("ввчедите число из отрезка от 10 до 99: ");
int n = Convert.ToInt32(Console.ReadLine());

while (true)
{
    if (( n >= 10) && ( n <= 99)) break;
    Console.WriteLine("число не из отрезка от 10 до 99: ");
    Console.Write("ввчедите число из отрезка от 10 до 99: ");
    n = Convert.ToInt32(Console.ReadLine());
}
 int n1 = n % 10;
 int n2 = n / 10;
 if (n1 > n2)
  {
      Console.WriteLine($"Наибольшая цифра числа {n} {n1}");
  }
  else
 {
       Console.WriteLine($"Наибольшая цифра числа {n} {n2}");
  }
    

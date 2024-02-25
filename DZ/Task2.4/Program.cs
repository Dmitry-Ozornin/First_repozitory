// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());

while (true)
{
    if (n > 10) break;
    
    Console.Write("'это цифра, натуральное число начинается с 10 ");
    Console.Write("введите натуральное число ");
    n = Convert.ToInt32(Console.ReadLine());
    
}
int counter = (int)Math.Log10(n);
// Console.Write("количество цифр :"+ counter);
int index = 0;
while (index < counter)
{
    int currentFigure = (int)(n / Math.Pow(10, counter-index))%10;

    Console.Write($"{currentFigure}, ");
    index++;
}

Console.Write($"{n%10}");





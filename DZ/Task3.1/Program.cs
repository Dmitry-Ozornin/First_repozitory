// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] Random_mas(int num)
{
    int[] mas = new int[num];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(100, 1000);
    }
    return mas;
    
}
void Print_mas(int[] mas)
{
    foreach (var i in mas)
    {
         Console.Write($"{i} ");
    }
    Console.WriteLine();
}

int Count(int[] num)
{   
    int c = 0;
    for ( int i = 0; i < num.Length; i++)
    {
        if ( num[i] % 2 ==0)
        {
            c = c + 1;
            Console.WriteLine($"четное {num[i]} "); // вывод четных чисел
        }
    }
    return c;
}


Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrey = Random_mas(n);
Print_mas(arrey);
Console.WriteLine(Count(arrey));

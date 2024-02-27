// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

int[] Random_mas(int num)
{
    int[] mas = new int[num];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(1, 10);
       
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


int[] New_mas(int[] mas)
{
    
        int[] new_mas = new int[mas.Length];
        for (int i = 0; i < mas.Length; i++)
        {
            new_mas[i] = mas[mas.Length - 1 - i];
        }
        return new_mas;
    
}
Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrey = Random_mas(n);
Print_mas(arrey);
Console.WriteLine(string.Join(" ",New_mas(arrey)));
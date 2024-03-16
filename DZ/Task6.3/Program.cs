// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

Random random = new Random();

int[] RandomArr(int size)
{
    int[] arr = new int[size];
    Array(arr, size -1);
    return arr;
}

void Array(int[] arr, int i)
{
    if (i < 0) return;
    arr[i] = random.Next(0, 100);
    Array(arr,i - 1);
    
    Console.Write($"{arr[i]} ");
}

void PrintArrayRevers(int[] arr, int i)
{
    if (i < 0) return;
    Console.Write(arr[i] + " ");
    PrintArrayRevers(arr, i -1);
}

Console.WriteLine(" Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = RandomArr(size);
Console.WriteLine();
Console.WriteLine(" массива в обратном порядке ");
PrintArrayRevers(arr, size - 1);
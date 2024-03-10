// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
char[,] array = new char[,] {{'a', 'b', 'c'}, {'d', 'f', 'g'}};

string st = string.Empty; // string.Empty или ""
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        st += array[i, j];
    }
}
Console.WriteLine(st);
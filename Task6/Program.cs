﻿// int Square(int value) //имя функции выполняющее возведение в квадрат ( параметы функции)
// // void указывается если функция не возвращается
// {
//     int result = value * value;
//     return result; // возвращение конкретной переменной
//     //Console.WriteLine(result) если функция не возвращается
// }

// //Пример функции без параметров

// void ShowHelloMessege() // без параметров, без возвращения значение
// {
//     Console.WriteLine(" Hello world");
// }

// double GetPi() // без параметров, c возвращения значение 
// {
//     return 3.14159;
// }

// void ShowHelloMessege(string messege) // c параметров, без возвращения значение
// {
//     Console.WriteLine(messege);
// }

// int AddValues(int a, int b) // c параметров, c возвращения значение 
// {
//     int result = a + b;
//     return result;
// }


//Задача 1

// double CalculateFormula(int a, int b, int c, int d)
// {
//     double numerator = a * b;
//     int denomerator = c + d;
//     double result = numerator / denomerator;
//     return result;
// }
// double result = CalculateFormula( 1, 2, 3, 4);
// Console.WriteLine(result);

// // Задача 2

// void PrintSquares( int n)
// {
//     int i = 1;
//     while ( i <= n)
//     {
//         Console.Write($"{i*i} ");
//         i++;
//     }
// }
// PrintSquares( 5);
// PrintSquares( 10);
// PrintSquares( 15);


// Задача 3: Функция которая обнулит четные элементы массива

void ZeroEvenElements (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int[] array = { 1, 2, 3,4,5};
ZeroEvenElements (array);
PrintArray(array);
// Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.
using System.Text; //подключение библиотеки( помогло писать на русском)
Console.InputEncoding = Encoding.Unicode; // для русского языка
Console.OutputEncoding = Encoding.Unicode; // для русского языка

Console.WriteLine("Введите строку ");
string inputString = Console.ReadLine()!;
Console.WriteLine(inputString.ToLower()!);

//  Типо идеальное решение
string input = "aBcD1ef!-";
// Преобразование всех заглавных букв в строчные
string result = input.ToLower();
// Вывод результата
Console.WriteLine(result);
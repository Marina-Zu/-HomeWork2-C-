// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

int number = Prompt("Ведите трехзначное число > ");
System.Console.WriteLine($"Введенное число {number}");
if (number > 999 | number < 100)
{
    System.Console.WriteLine("Это не трехзначное число. Пробуйте еще раз");
}
else
{
    int number1 = number / 10;
    int number2 = number1 % 10;
    System.Console.WriteLine($"Вторая цифра {number2}");
}
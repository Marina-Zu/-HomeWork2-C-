// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.


int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

int num = Prompt("Введите число > ");
int num3 = 0;
if (num < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    while (num / 100 > 0)
    {
        num3 = num % 10;
        num = num / 10;
    }
    System.Console.WriteLine($"Третья цифра {num3}");
}
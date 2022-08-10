// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

int daynum = Prompt("Введите номер дня недели > ");
if (1 <= daynum && daynum <= 7)
{

    if (1 <= daynum && daynum <= 5)
    {
        System.Console.WriteLine("Нет, будний день");
    }
    if (daynum == 6 | daynum == 7)
    {
        System.Console.WriteLine("Да, выходной");
    }
}
else
{
    System.Console.WriteLine("Нет такого дня недели");
}

//  Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.

int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);
int number1 = number % 10;
int number2 = number / 100;
System.Console.Write(number2);
System.Console.Write(number1);

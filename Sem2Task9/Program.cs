﻿//Создаем эеземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();


// Получаем новое случайное число
int number = numberSintezator.Next(10,100);

// Выводим данные в консоль
Console.WriteLine(number);

// Получаем первое и второе  число поотдельности
int firstNumber = number/10;
int secondNumber = number%10;

// Сравниваем числа
if(firstNumber>secondNumber)
{
    // Выводим данные в консоль
    Console.WriteLine(firstNumber);
}
else
{
    //Выводим данные в консоль
    Console.WriteLine(secondNumber);
}
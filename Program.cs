﻿//Задача 64: Задайте значение N. Напишите программу,
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int number)
{
    Console.Write(number + " ");
    if(number > 1) ShowNums(number - 1);
    
}
Console.Write("Input number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
ShowNums(userNumber);
*/

//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumOfNumbers(int number1, int number2)
{
    
    if(number1 < number2 + 1) return number1  + SumOfNumbers(number1 + 1, number2);    //проверка условия, чтобы суммирование закончилось на number2, а не на предыдущем числе
    //if(number1 < number2) return number1 + number2 + SumOfNumbers(number1 + 1, number2);  //попытка закончить вызов рекурсии на числе number2 - 1, прибавив его вне рекурсии. Результат вообще не понятно откуда берётся. Не понимаю что с чем складывается
        
    //if(number2 < number1 + 1) return number2 + SumOfNumbers(number1, number2 + 1);

    return 0;
    
}

Console.Write("Введите первое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
int result = SumOfNumbers(userNumber1, userNumber2);
Console.WriteLine($"Сумма числел между {userNumber1} и {userNumber2} равна {result} ");
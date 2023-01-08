//Задача 64: Задайте значение N. Напишите программу,
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
/*
int SumOfNumbers(int number1, int number2)
{
    if (number1 == number2) return number1;
    else 
        if(number1 > number2) return number1 + SumOfNumbers(number1 - 1, number2);
        else return number2 + SumOfNumbers(number1, number2 - 1);
}

Console.Write("Введите первое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

int sum = SumOfNumbers(userNumber1, userNumber2);
Console.WriteLine($"Сумма чисел от {userNumber1} до {userNumber2} равна: {sum}");
*/


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

int Accerman(int n, int m)
{
    if (n == 0) return m + 1;
    else 
        if (m == 0) return Accerman (n - 1, 1);
        else return Accerman(n - 1, Accerman (n, m - 1));
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = Accerman(number1, number2);
Console.WriteLine(result);

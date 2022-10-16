/*
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (и в нулевую степень). Использовать свои функции, не использовать Math.Pow

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidatePower(int number)
{
    if (number < 0)
    {
        Console.WriteLine("Степень должна быть натуральной!");
        return false;
    }
    return true;
}

int PowerOfNumber (int number, int power)
{
    int result = 1;
    for (int i = 0; i < power; i ++)
    {
        result *= number;
    }
    return result;
}

int firstNumber = Prompt("Введите число для возведения в степень: ");
int secondNumber = Prompt("Введите натуральную степень: ");
if (ValidatePower(secondNumber)) Console.WriteLine($"Число {firstNumber} в степени {secondNumber} равно {PowerOfNumber(firstNumber, secondNumber)}!");
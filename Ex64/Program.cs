// Урок 9. Рекурсия
// Задача 64: Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetUserInputInt(string userInputString)
{
    Console.WriteLine(userInputString);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void WriteNaturalNumbresNTo1(int number)
{
    if (number == 0) return;
    Console.Write($"{number} ");
    WriteNaturalNumbresNTo1(number - 1);
}


Console.Clear();
int num = GetUserInputInt("Введите либое натуральное число: ");
Console.WriteLine($"Ряд натуральных чисел от {num} до 1: ");
WriteNaturalNumbresNTo1(num);
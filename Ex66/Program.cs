// Урок 9. Рекурсия
// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

string[] GetUserInputNumbersString(string userInputTextString)
{
    Console.WriteLine(userInputTextString);
    string[] userInputString = Console.ReadLine().Split(",");
    return userInputString;
}

void CheckUserInputToInt(string[] userInputString)
{
    for (int i = 0; i < userInputString.Length; i++)
    {
        if (userInputString[i] == string.Empty || userInputString[i] == " "
            || Convert.ToInt32(userInputString[i]) == null
            || userInputString.Length < 2)
        {
            Console.WriteLine("Ошибка ввода данных. Попробуйте еще раз запустить программу и ввести данные корректно.");
            Environment.Exit(0);
        }
    }
}

int[] ConvertUserInputNumbersInt(string[] userNumberString)
{
    int[] userNumberInt = new int[userNumberString.Length];
    for (int i = 0; i < userNumberString.Length; i++)
    {
        userNumberInt[i] = Convert.ToInt32(userNumberString[i]);
    }
    return userNumberInt;
}

int GetSumNaturalNumbersMToN(int m, int n)
{
    int sum = m;
    if (m >= n) return sum;
    return sum += GetSumNaturalNumbersMToN(++m, n);
}


Console.Clear();
string[] arrayNaturalNumberIntervalString = GetUserInputNumbersString("Введите интервал значений натуральных чисел через запятую: ");
CheckUserInputToInt(arrayNaturalNumberIntervalString);
int[] arrayNaturalNumberIntervalInt = ConvertUserInputNumbersInt(arrayNaturalNumberIntervalString);
int sum = GetSumNaturalNumbersMToN(arrayNaturalNumberIntervalInt[0], arrayNaturalNumberIntervalInt[1]);
Console.WriteLine($"Сумма всех натуральных чисел в заданном интервале: {sum}");
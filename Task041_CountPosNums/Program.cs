// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите последовательность чисел через запятую: ");
string sequenceNumbers = Console.ReadLine();

int[] arrayNumbers = CheckArray(sequenceNumbers, ',');
PrintArray(arrayNumbers);

int countPosNums = 0;
for (int i = 0; i < arrayNumbers.Length; i++)
{
    if (arrayNumbers[i] > 0)
        countPosNums++;
}
Console.WriteLine("Количество чисел больше нуля = " + countPosNums);

int[] CheckArray(string input, char comma)
{
    int[] numbers = new int[countCommas(input)];
    string numberWithoutComma = String.Empty;
    int numberIndex = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == comma)
        {
            numbers[numberIndex] = Convert.ToInt32(numberWithoutComma);
            numberIndex++;
            numberWithoutComma = String.Empty;
        }
        else
        {
            numberWithoutComma += input[i];
        }
    }
    numbers[numberIndex] = Convert.ToInt32(numberWithoutComma);
    return numbers;
}

int countCommas(string numbers)
{
    int count = 1;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == ',')
            count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

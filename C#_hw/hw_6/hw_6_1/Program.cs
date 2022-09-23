// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Ввод числовых данных с клавиатуры и подсчет количества введенных положительных чисел
int PositiveCount(string SomeLine)
{
    Console.WriteLine(SomeLine);
    int countPositive = 0;
    while (true)
    {
        string inputLine = Console.ReadLine() ?? "0";
        bool isNumber = int.TryParse(inputLine, out int inputNumber);
        if (isNumber)
        {
            if (inputNumber > 0)
            {
                countPositive += 1;
            } 
        }
        else
        {
            break;
        }
    }
    return countPositive;
}

// Вывод результата
void PrintResult(int SomeNumber)
{
    Console.WriteLine($"Количество введенных положительных чисел: {SomeNumber}");
}

PrintResult(PositiveCount(("Вводите числа по одному, нажимая Enter. Для завершения ввода введите нечисловое значение и нажмите Enter.")));
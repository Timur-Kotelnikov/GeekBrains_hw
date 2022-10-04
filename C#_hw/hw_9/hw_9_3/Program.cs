// Напишите программу вычисления функции Аккермана с помощью рекурсии. 

// Ввод данных с клавиатуры
int InputNumber(string someString)
{
    Console.WriteLine(someString);
    int resultNumber = int.Parse(Console.ReadLine() ?? "0");
    return resultNumber;
}

int numberM = InputNumber("Введите первое число");
int numberN = InputNumber("Введите второе число");

// Расчет значения
int Ackermann(int firstNumber, int secondNumber)
{
    if (firstNumber == 0)
    {
        return secondNumber+1;

    }
    if (firstNumber > 0 && secondNumber == 0)
    {
        return Ackermann(firstNumber-1, 1);
    }
    if (firstNumber > 0 && secondNumber > 0)
    {
        return Ackermann(firstNumber-1, Ackermann(firstNumber, secondNumber-1));
    }
    return 0;
}

Console.WriteLine($"Результат = {Ackermann(numberM, numberN)}");
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 

// Ввод данных (число N) с клавиатуры
int InputNubmer()
{
    Console.WriteLine("Введите число:");
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

//Вывод в консоль натуральных чисел от N до 1 включительно
void RecursiveN(int someNumber)
{
    Console.WriteLine(someNumber);
    if (someNumber != 1)
    {
        if (someNumber < 1)
        {
            RecursiveN(someNumber+1);
        }
        else
        {
            RecursiveN(someNumber-1);
        }
    }
}

RecursiveN(InputNubmer());
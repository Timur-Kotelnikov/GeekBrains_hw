// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// Ввод данных и задание длины массива
int ReadData(string SomeLine)
{
    Console.WriteLine(SomeLine);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

int LengthOfArray = ReadData("Введите длину массива");

// Создание массива заданной длины (случайные целые значения в диапазоне от 100 до 999)
int[] CreateArray(int SomeNum)
{
    int[] SomeArray = new int [SomeNum];
    Random rnd = new Random();
    for (int i = 0; i < SomeNum; i ++)
    {
        SomeArray[i] = rnd.Next(100, 1000);
    }
    return SomeArray;
}

int[] array = CreateArray(LengthOfArray);

// Нахождение количества четных чисел в массиве
int CountEvenNuminArray(int[] SomeArray)
{
    int Count = 0;
    foreach (int i in SomeArray)
    {
        if (i % 2 == 0)
        {
            Count += 1;
        }
    }
    return Count;
}

// Вывод результата
void PrintResult(int[] SomeArray)
{
    Console.WriteLine($"Количество четных чисел в массиве: {CountEvenNuminArray(SomeArray)}");
}

for (int i = 0; i < array.Length-1; i ++)
{
    Console.Write($"{array[i]}  ");
}
Console.WriteLine(array[array.Length-1]);

PrintResult(array);


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// Ввод данных и задание длины массива
int ReadData(string SomeLine)
{
    Console.WriteLine(SomeLine);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

int LengthOfArray = ReadData("Введите длину массива");

// Создание массива заданной длины (случайные целые значения)
int[] CreateArray(int SomeNum)
{
    int[] SomeArray = new int[SomeNum];
    Random rnd = new Random();
    for (int i = 0; i < SomeNum; i++)
    {
        SomeArray[i] = rnd.Next();
    }
return SomeArray;
}

int[] array = CreateArray(LengthOfArray);

// Нахождение суммы элементов массива с нечетными индексами
int SumOfOddPositionElements(int[] SomeArray)
{
    int Total = 0;
    for (int i = 0; i < SomeArray.Length; i++)
    {
        if (i % 2 == 1)
        {
            Total += SomeArray[i];
        }
    }
    return Total;
}

//Вывод результата
void PrintResult(int[] SomeArray)
{
    Console.WriteLine($"Сумма элементов массива с нечетными индексами: {SumOfOddPositionElements(SomeArray)}");
}

for (int i = 0; i < array.Length-1; i ++)
{
    Console.Write($"{array[i]}  ");
}
Console.WriteLine(array[array.Length-1]);

PrintResult(array);
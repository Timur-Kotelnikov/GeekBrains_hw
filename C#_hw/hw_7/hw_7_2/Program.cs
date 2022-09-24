// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Ввод данных и задание размеров массива
int ReadData(string someLine)
{
    Console.WriteLine(someLine);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

int amountLines = ReadData("Введите количество строк массива");
int amoutColumns = ReadData("Введите количество столбцов массива");

// Создание массива заданного размера
double[,] CreateArray(int someNumberLines, int someNumberColumns)
{
    double[,] someArray = new double[someNumberLines, someNumberColumns];
    Random rnd = new Random();
    for (int i = 0; i < someNumberLines; i++)
    {
        for (int j = 0; j < someNumberColumns; j++)
        {
            someArray[i, j] = Math.Round(rnd.NextDouble() * 100, 2);
        }
    }
    return someArray;
}

double[,] myArray = CreateArray(amountLines, amoutColumns);

// Вывод массива
void PrintResultArray(double[,] someArray)
{
    Console.WriteLine("Созданный массив:");
    for (int i = 0; i < someArray.GetLength(0); i++)
        {
            for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    Console.Write($"{someArray[i, j]} ");
                }
            Console.WriteLine();
        }
}

PrintResultArray(myArray);

// Ввод координат искомого элемента и вывод его значения
void PrintResultNumber(string someThing, double[,] someArray)
{
    Console.WriteLine(someThing);
    string? inputLine = Console.ReadLine();
    if (inputLine != null)
    {
        int coordinateLine = int.Parse(inputLine.Split(",")[0]);
        int coordinateColumn = int.Parse(inputLine.Split(",")[1]);
        if ((coordinateLine < someArray.GetLength(0)+1) & (coordinateColumn < someArray.GetLength(1)+1))
        {
            Console.WriteLine($"Значение элемента = {someArray[coordinateLine-1, coordinateColumn-1]}");
        }
        else
        {
            Console.WriteLine("Такого элемента нет");
        }
    }
}

PrintResultNumber("Введите координаты элемента в формате: номер строки, номер столбца", myArray);
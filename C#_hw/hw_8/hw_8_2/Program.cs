// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Создание массива
int[,] CreateArray(int amountLines, int amoutColumns)
{
    int[,] someArray = new int[amountLines, amoutColumns];
    Random rnd = new Random();
    for (int i = 0; i < amountLines; i++)
    {
        for (int j = 0; j < amoutColumns; j++)
        {
            someArray[i, j] = rnd.Next(0, 10);
        }
    }
    return someArray;
}

int[,] myArray = CreateArray(4, 5);

// Вывод массива
void PrintResultArray(string someString, int[,] someArray)
{
    Console.WriteLine(someString);
    for (int i = 0; i < someArray.GetLength(0); i++)
        {
            for (int j = 0; j < someArray.GetLength(1); j++)
                {
                    Console.Write($"{someArray[i, j]} ");
                }
            Console.WriteLine();
        }
}

PrintResultArray("Созданный массив:", myArray);

//Поиск строки с наименьшей суммой элементов
int GetLineWithHighestSumOfElements(int[,] someArray)
{
    int[] allSumsOfElements = new int[someArray.GetLength(0)];
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        int sumOfElements = 0;
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            sumOfElements += someArray[i, j];
        }
        allSumsOfElements[i] = sumOfElements;
    }
    int minValue = 100;
    int indexMinValue = 0;
    for (int i = 0; i < allSumsOfElements.GetLength(0); i++)
    {
        if (allSumsOfElements[i] < minValue)
        {
            minValue = allSumsOfElements[i];
            indexMinValue = i;
        }
   }
   return indexMinValue+1;
}

GetLineWithHighestSumOfElements(myArray);
Console.WriteLine($"Строка с наименьшей суммой элементов: {GetLineWithHighestSumOfElements(myArray)}");
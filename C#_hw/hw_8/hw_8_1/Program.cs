// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

// Создание массива
int[,] CreateArray(int amountLines, int amoutColumns)
{
    int[,] someArray = new int[amountLines, amoutColumns];
    Random rnd = new Random();
    for (int i = 0; i < amountLines; i++)
    {
        for (int j = 0; j < amoutColumns; j++)
        {
            someArray[i, j] = rnd.Next(-10, 10);
        }
    }
    return someArray;
}

int[,] myArray = CreateArray(4, 4);

// Создание нового массива с элементами строк, расположенными по убыванию
int[,] RemakeArrayInOrder(int[,] someArray)
{
    int[,] newArray = new int[someArray.GetLength(0), someArray.GetLength(1)];
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        int[] subList = new int[someArray.GetLength(1)];
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            subList[j] = someArray[i, j];
        }
        subList = subList.OrderByDescending(c => c).ToArray();
        for (int q = 0; q < subList.GetLength(0); q++)
            {
                newArray[i, q] = subList[q];
            } 
    }
    return newArray;
}

int[,] newArray = RemakeArrayInOrder(myArray);

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
PrintResultArray("Измененный массив:", newArray);
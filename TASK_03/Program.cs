// Задача 3: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray(int m = 3, int n = 4)
{
    Random rnd = new Random();
    int[,] array = new int[3, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// double FindAverageColumn(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int sum = 0;
//         double average;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum += array[i, j];
//         }
//         average = sum / array.GetLength(0);
//         return average;
//     }
//     return array.GetLength(1);
// }

double FindAverageColumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        double average;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        return Enumerable.Range(0, array.GetLength(1)).Select(j => array.GetColumn(x).Sum() / array.GetLength(1));
    }
    return array.GetLength(1);
}

int[,] resultArray = CreateArray();
PrintArray(resultArray);
double averageColumn = FindAverageColumn(resultArray);
Console.WriteLine($"Среднее арифметическое каждого столбца массива: {averageColumn:F1}; ");
Console.WriteLine();

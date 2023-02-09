// Задача 2: Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 4


int[,] CreateArray(int m = 3, int n = 4)
{
    Random rnd = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
    }
    Console.WriteLine();
}

int InputInt(string msg)
{
    Console.Write(msg + " : ");
    return Convert.ToInt32(Console.ReadLine()) - 1;
}

(bool, int, int) FindNumber(int[,] array, int line, int column)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == array[line, column])
            {
                return (true, i, j);
            }
        }
    }
    return (false, 0, 0);
}

int[,] resultArray = CreateArray();
PrintArray(resultArray);
int line = InputInt("Введите номер строки ");
int column = InputInt("Введите номер столбца ");

(bool check, int number, int number2) = FindNumber(resultArray, line, column);
if (check)
{
    Console.WriteLine($"По данным координатам в массиве находится число: {resultArray[number, number2]}");
}
else
{
    Console.WriteLine($"Такого числа нет в массиве!");
}
Console.WriteLine();

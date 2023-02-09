// Задача 3: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.WriteLine("Задайте двумерный массив m x n");
Console.Write("\nВведите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.Write($"\nДвумерный массив размера 'm = {m}' на 'n = {n}':\n");
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.Write("\nCреднее арифметическое элементов в каждом столбце\n");
for (int i = 0; i < n; i++)
{
    double number = 0;
    for (int j = 0; j < m; j++)
    {
        number = (number + matrix[j, i]);
    }
    Console.Write(Math.Round((number / m), 1) + "   ");
}
Console.WriteLine();
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] GenerateArray(int rowLength, int colLength)
{
    double[,] array = new double[rowLength, colLength];
    Random r = new Random();
    for (var i = 0; i < rowLength; i++)
    {
        for (var j = 0; j < colLength; j++)
        {
            array[i, j] = r.NextDouble();
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:F2}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
double[,] numbers = GenerateArray(3, 3);
PrintArray(numbers);

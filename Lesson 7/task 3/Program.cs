// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GenerateArray(int rowLength, int colLength)
{
    int[,] array = new int[rowLength, colLength];
    Random r = new Random();
    for (var i = 0; i < rowLength; i++)
    {
        for (var j = 0; j < colLength; j++)
        {
            array[i, j] = r.Next(0, 9);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
int[,] numbers = GenerateArray(3, 3);
PrintArray(numbers);

int Average(int[,] numbers)
{
    int avg = 0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        int sum = 0;
        for (int i = 0; i < numbers.GetLength(1); i++)
        {
            sum = sum + numbers[i, j];
        }
        avg = sum / numbers.GetLength(1);
        System.Console.Write($"{avg}\t");

    }
    return avg;


}

Average(numbers);


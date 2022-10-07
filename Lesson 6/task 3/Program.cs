// Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

int[,] GenerateArray(int rowLength, int colLength)
{
    var array = new int[rowLength, colLength];
    Random r = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = r.Next(1, 9);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
int[,] numbers = GenerateArray(3, 3);
PrintArray(numbers);


int SumMinCol(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < 3; i++)
    {
        int min = array[0, 0];
        for (int j = 0; j < 3; j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
            }
        }
        sum = sum + min;
    }
    return sum;
}

SumMinCol(numbers);
System.Console.WriteLine($"Сумма минимальных чисел в столбцах: {SumMinCol(numbers)}");


int SumMaxStr(int[,] array)
{
    int sum = 0;
    for (int j = 0; j < 3; j++)
    {
        int max = array[0, j];
        for (int i = 0; i < 3; i++)
        {
            if (array[i, j] > max)
            {
                max = array[i, j];
            }
        }
        sum = sum + max;
    }
    return sum;
}

SumMaxStr(numbers);
System.Console.WriteLine($"Сумма максимальных чисел в строках: {SumMaxStr(numbers)}");
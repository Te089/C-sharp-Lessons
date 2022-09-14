// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GenerateArray(int length, int minRandom, int maxRandom)
{
    Random rnd = new Random();
    int[] answer = new int[length];
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(minRandom, maxRandom + 1);
    }
    return answer;
}


void PrintArray(int[] array)
{
    System.Console.WriteLine("Новый сгенерированный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "; ");
    }
    System.Console.WriteLine();
}

int[] massive = GenerateArray(6, 1, 10);
PrintArray(massive);

int max = massive[0];
int min = massive[0];
for (int i = 0; i < massive.Length; i++)
{
    if (massive[i] > max)
    {
        max = massive[i];
    }
    if (massive[i] < min)
    {
        min = massive[i];
    }
}

int diff = max - min;
System.Console.WriteLine($"Максимальный элемент массива : {max}");
System.Console.WriteLine($"Минимальный элемент массива : {min}");
System.Console.WriteLine($"Разница между максимальным и минимальным элементов массива : {diff}");
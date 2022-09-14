// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int[] massive = GenerateArray(5, 100, 999);
PrintArray(massive);

int count = 0;
for (int i = 0; i < massive.Length; i++)
{
    if (massive[i] % 2 == 0)
    {
        count++;
    }
}
System.Console.WriteLine($"Количество четных чисел в массиве - {count}");
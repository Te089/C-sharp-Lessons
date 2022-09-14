// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int summ = 0;
for (int i = 0; i < massive.Length; i++)
{
    if (i % 2 == 1)
    {
        summ = summ + massive[i];
    }
}
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях : {summ}");
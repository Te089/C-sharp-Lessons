// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
// Также ищет второй максимум (число меньше максимального элемента, но больше всех остальных)
// 8 1 2 4 4 5 3 1 -> 5
// 1 2 6 9 8 1 1 1 -> 8
// 2 1 2 1 1 1 1 1 -> 1
// 1 2 1 2 1 1 1 1 -> 1
// 1 2 3 4 5 6 7 8 -> 7
// 1 2 3 4 5 6 8 7 -> 7

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

int[] massive = GenerateArray(8, 1, 9);
PrintArray(massive);

int max = massive[0];
int secondMax = massive[1];
if (massive[0] > massive[1])
{
    for (int i = 2; i < massive.Length; i++)
    {
        if (massive[i] >= max)
        {
            secondMax = max;
            max = massive[i];
        }
        else if (massive[i] > secondMax)
        {
            secondMax = massive[i];
        }
    }
}
System.Console.WriteLine($"Второй максимум в массиве - {secondMax}");
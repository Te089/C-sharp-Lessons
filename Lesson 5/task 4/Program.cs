// Заполнить массив четной длины таким образом, чтобы значение элемента массива повторялось ровно 2 раза.
// 1,1,2,3,3,2,4,5,4,5
// или
// 1,1,2,2,4,4,5,5
// или
// 1,2,3,3,2,1

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

int[] massive = GenerateArray(8, 1, 25);

for (int i = 0; i < massive.Length/2; i++)
{
    massive[i] = massive[i+4];
}

PrintArray(massive);
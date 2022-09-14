// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GenerateArray(int length)
{
Random rnd = new Random();
int[] answer = new int[length];
for (int i = 0; i < answer.Length; i++)
{
answer[i] = rnd.Next();
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

int[] massive = GenerateArray(8);
PrintArray(massive);
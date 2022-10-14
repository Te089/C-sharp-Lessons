// Написать программу, которая из имеющегося массива строк формирует массив
//  из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// ["hello","2","world",":-)"] -> ["2",":-)"]

string[] massive = { "hello", "2", "world", "heh" };

void PrintArray(string[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        Console.Write($"{massive[i]};  ");
    }
    Console.WriteLine();
}

PrintArray(massive);

void PrintNewArray(string[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i].Length <= 3)
        {
            Console.Write($"{massive[i]};  ");
        }
    }
}

PrintNewArray(massive);
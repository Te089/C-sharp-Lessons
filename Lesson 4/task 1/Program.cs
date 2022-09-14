// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Prompt(string message)
{
System.Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

int NumberA = Prompt("Введите число А >");
int NumberB = Prompt("Введите число B >");

int result = 1;

for (int i = 1; i <= NumberB; i++)
{
    result = result * NumberA;
}

System.Console.WriteLine(result);
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Prompt(string message)
{
System.Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

int Number = Prompt("Введите число >");

int summ = 0;

while (Number > 0)
{
    summ = summ + Number%10;
    Number = Number/10;
}

System.Console.WriteLine($"Сумма цифр числа равна {summ}");
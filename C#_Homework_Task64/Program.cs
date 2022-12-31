// 64: Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;

void PrintNumbers(int N, int count)
{
    if (N >= count)
    
    {
       PrintNumbers(N, count + 1);
       Console.Write(count + " "); 
    }
    else
    {
        return;
    }
}

PrintNumbers(N, count);


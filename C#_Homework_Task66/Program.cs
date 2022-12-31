// 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите первое число");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int M, int N)
{
    if (M < N)
    {       
        return (N + SumNumbers(M, N - 1));    
    }
    else if (M == N)
    {
        return M;
    }
    else if(M > N)
    {
        return N + SumNumbers(M, N + 1);  
    }
    else if (M == 0)
    { 
        return (N * (N + 1)) / 2;
    } 
    else
    { 
        return (M * (M + 1)) / 2;
    }

}
Console.WriteLine(SumNumbers(M, N));




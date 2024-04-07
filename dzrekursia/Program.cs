//Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать цикл


using System.Diagnostics;

Console.WriteLine(value: "Введите первое число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(value: "Введите второе число ");
int n = Convert.ToInt32(value: Console.ReadLine());


PrintNaturalNumbers(m, n); 
void PrintNaturalNumbers(int M, int N) 
{
    if (M <= N) 
        { 
            Console.Write(M + " "); 
            PrintNaturalNumbers(M + 1, N); 
        } 
}

Console.WriteLine();
//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.WriteLine(value: "Введите первое число ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(value: "Введите второе число ");
int j = Convert.ToInt32(value: Console.ReadLine());


int Ack (int I, int J)
{
    if(I == 0) return J+1;
    else if(J== 0) return Ack(I -1, 1);
    return Ack(I-1, Ack (I, J -1));
}

int res = Ack(i, j);
Console.Write(res);


//Задайте произвольный массив. Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.
Console.WriteLine();

int[] Arr = {2,4,3,8,9,5};
PrintArrayReverse(Arr, Arr.Length - 1); 
void PrintArrayReverse(int[] arr, int index) 
    { 
        if (index >= 0) 
        { 
            Console.Write(arr[index] + " "); 
            PrintArrayReverse(arr, index -1); 
        } 
    } 

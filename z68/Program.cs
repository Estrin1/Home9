// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//A[m,n]=A[m-1,A[m,n-1]] if  m> 0 N>0
//n+1 if m=0
//A(m-1,1) if m>0 & n=0;
void Zadacha68()
{
    Console.WriteLine("Введите M ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите N ");
    int N = Convert.ToInt32(Console.ReadLine());
    int result =  RecAccerman(M, N);
    Console.WriteLine("\n" + "Значение функции " + result);
}

    int RecAccerman(int m, int n)
    {
        
        if (m == 0) return n + 1;
        else if (n == 0) return RecAccerman(m - 1, 1);
        else   return RecAccerman(m - 1, RecAccerman(m, n - 1));
    }
    

Zadacha68();
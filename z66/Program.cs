// Задача 66: Задайте значения M и N. Напишите рекурсивный метод, 
// который найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Zadacha66()
{
    Console.WriteLine("Введите M ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите N ");
    int N = Convert.ToInt32(Console.ReadLine());
    
     
   void RecSumm(int a, int b, int summ=0)
    {
        
        if (a > b) 
        {Console.WriteLine(summ); 
        return ;
        }
        summ += a;
        RecSumm(a+1, b,summ);
        
    }
    RecSumm(M, N);
}
Zadacha66();
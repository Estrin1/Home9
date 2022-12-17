// Задача 64: Задайте значения M и N. Напишите рекурсивный метод, 
// который выведет все натуральные числа кратные 3-ём в промежутке 
// от M до N.
// M = 1; N = 9. -> "3, 6, 9"
// M = 13; N = 20. -> "15, 18"
void Zadacha64()
{
Console.WriteLine("Введите M ");
int M = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Введите N ");
int N = Convert.ToInt32( Console.ReadLine());


void Kratnost3(int a, int b)
{
int count = a;
if (count>b) return;
if (count %3==0) Console.Write(count + "\t ");
Kratnost3(a+1,b);
}
Kratnost3(M,N);
}
Zadacha64();
// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumOfValues(int m, int n){
    if(n == m)
        return n;
    else
        return m + SumOfValues(m+1, n);
}
Console.Write("Enter M nubmer: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N nubmer: ");
int n = Convert.ToInt32(Console.ReadLine());
if(m>n){
    Console.WriteLine("Error: M number is bigger then N");
}
else{
Console.WriteLine(SumOfValues(m,n));
}
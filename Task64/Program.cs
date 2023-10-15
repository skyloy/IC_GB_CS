// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// В промежутке от N до 1. Выполнить с помощью рекурсии.
void ShowValues(int n){
    Console.Write($"{n} ");
    if(n > 1){
        ShowValues(n-1);
    }
}
Console.Write("Enter N nubmer: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowValues(n);
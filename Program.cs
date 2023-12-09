// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

/*
string printNumber (int m, int n){
    if (m == n)
        return Convert.ToString(n);
    return printNumber (m, n - 1) + $" {n}";
}

Console.Clear();
Console.WriteLine("Введите 1- ое число: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 2- ое число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(printNumber(M,N));
*/
// =========================

//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
/*
int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

Console.Clear();
Console.WriteLine("Введите 1- ое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 2- ое число: ");
int n = int.Parse(Console.ReadLine()!);

int functAkkerman = Ack(m, n);
Console.Write($"Функция Аккермана = {functAkkerman} ");
*/
// ============================

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void printArrRevers (int[]arr, int n){
    
    if (n == 0) return;

    Console.Write(arr[n-1] + " ");
    printArrRevers (arr, n - 1);
}


void InputArray (int[] array){
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 31);
}

Console.Clear();
Console.WriteLine("Enter number of array elrments: ");
int n = int.Parse(Console.ReadLine()!);
int [] array = new int [n];
InputArray (array);
Console.WriteLine($"Starting array: [{string.Join(", ", array)}]");
printArrRevers(array, n);
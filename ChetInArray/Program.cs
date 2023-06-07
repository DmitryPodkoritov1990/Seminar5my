// Задайте массив, заполненный случайными положительными трехзначными числами. 
//Напишите программу, которая покажет количество четных чисел в массиве.

int[] myArray90(int size)
{
    int[] triple = new int[size];
    for (int i = 0; i < size; i++)
    {
        triple[i] = new Random().Next(100, 1000);
        
    }
    return triple;
}

void PrintnewArray(int[] arrow)
{
    for (int i = 0; i < arrow.Length; i++)
    {
        Console.Write($"{arrow[i]} ");
    }
}

void FindChetSum(int[] arr1)
{
    
    int count = 0;
    foreach (int el in arr1)
    {
    if (el % 2 == 0)
    {
        count += 1; // positiveSum = positiveSum +  el
    }  
    }
    Console.WriteLine(count);
}

int[] mynewArr = myArray90(5);
PrintnewArray(mynewArr);
Console.WriteLine(" ");
FindChetSum(mynewArr);


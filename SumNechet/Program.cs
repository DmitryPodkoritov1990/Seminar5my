//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] NewMyArray(int size, int minValue, int maxValue)
{
    int[] nech = new int[size];
    for (int i = 0; i < size; i++)
    {
        nech[i] = new Random().Next(minValue, maxValue + 1);
        
    }
    return nech;
}

void PrintNewArray(int[] posnech)
{
    for (int i = 0; i < posnech.Length; i++)
    {
        Console.Write($"{posnech[i]} ");
    }
}

void FindNechet(int[] indexnechet)
{
    int sumNechet = 0;
    for (int i = 0; i < indexnechet.Length; i++)
    {
        if (i % 2 == 0)
        {
            sumNechet = sumNechet + indexnechet[i];
            Console.WriteLine("");
        }
    }
    Console.WriteLine($"Сумма значений нечетных индексов равна = {sumNechet} ");
}

int[] myNeCHET = NewMyArray(5, -5, 6);
PrintNewArray(myNeCHET);
FindNechet(myNeCHET);
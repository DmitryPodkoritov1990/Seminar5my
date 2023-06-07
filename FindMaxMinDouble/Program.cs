// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


   
Console.Clear ();

double[] arrayRan = new double[10];
Random rand = new Random();
 for (int i = 0; i < arrayRan.Length; i++)
 {
    arrayRan[i] = rand.NextDouble()*100;
    Console.WriteLine(arrayRan[i]);
 }


    double max = arrayRan[0];  

    for (int i = 0; i < arrayRan.Length; i++)
    {
 
    if (arrayRan[i] > max)
    {
        
        arrayRan[i] = max;
    }  

     Console.WriteLine("Max " + arrayRan[i]);
}




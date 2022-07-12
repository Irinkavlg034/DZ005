void Zadacha34()
{
  //  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
  //[345, 897, 568, 234] -> 2
  int[] array = new int[6];
  FillArray(array, 40, 89);
  PrintArray(array);
  CountEvenNumbers(array);
}
  void CountEvenNumbers(int[] array)
{ 
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
     if (array[i] % 2 == 0) count++;
  }
  Console.WriteLine("Количество чётных чисел в массиве равно; " + count); 
}

void FillArray(int[] array, int startNumber = 0, int finisNumber = 1)
{
    finisNumber++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, finisNumber);
    }
}
void PrintArray(int[] array)
{
    Console.WriteLine("Вывод массива"); 
   for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    } 
    Console.WriteLine(); 
}

 void Zadacha36()
{   //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    //[3, 7, 23, 12] -> 19
    //[-4, -6, 89, 6] -> 0
  int[] array = new int[6];
  FillArray(array, 40, 89);
  PrintArray(array);

  int sum = 0;
  for (int i = 0; i < array.Length; i++)
    {
        if (1 % 2 == 1) sum += array[i];
    }
    Console.WriteLine("Сумма элементов, стоящих на нечетных позициях, равна " + sum); 
}

 void Zadacha38()
 {
    //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    //[3 7 22 2 78] -> 76
    
    Random random = new Random();
    double[] array = new double[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble(),3); 
    }
 
    Console.WriteLine("Вывод массива"); 
   for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    } 
    Console.WriteLine(); 

    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
       Console.WriteLine("Максимальное значение равно: " + max);
       Console.WriteLine("Минимальное значение равно: " + min);
       Console.WriteLine("Их разность равна: " + (max - min));   
}

//Zadacha34();
//Zadacha36();
Zadacha38();


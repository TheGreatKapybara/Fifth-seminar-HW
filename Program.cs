System.Console.WriteLine("Выберете задачу");
System.Console.WriteLine("1 - Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]");
System.Console.WriteLine("2 - Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.");
System.Console.WriteLine("Результат запишите в новом массиве.");
System.Console.WriteLine("3 - Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.");
System.Console.WriteLine("Напишите программу, которая покажет количество чётных чисел в массиве.");
System.Console.WriteLine("4 - Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
System.Console.WriteLine("5 - Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
int TaskIndex = Convert.ToInt32(Console.ReadLine());

if(TaskIndex == 0)
{
    System.Console.WriteLine("Такой задачи нет");
}

if(TaskIndex > 5)
{
    System.Console.WriteLine("Такой задачи нет");
}


if (TaskIndex == 1)
{
    int[] array = new int[123];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    int counter = 0;
    for (int i = 10; i < 99; i++)
    {
        counter = counter + 1;
    }
    System.Console.WriteLine(counter);
}

if (TaskIndex == 2)
{
    int[] array = { 1, 6, 44, 5, 8, 11, 43 };
    int length = array.Length - 1;
    int unCount = array.Length % 2;
    int proLength = array.Length / 2;
    if (unCount != 0)
    {
        proLength = proLength + 1;
    }
    int[] pro = new int[proLength];
    for (int i = 0; i < length + 1; i++)
    {
        if (i == length)
        {
            pro[i] = array[i];
        }
        else
            pro[i] = array[i] * array[length];
        length--;
    }
    for (int i = 0; i < pro.Length; i++)
    {
        Console.Write(pro[i] + " ");
    }
}

if(TaskIndex == 3)
{
        int[] ContArray = {234, 934, 234, 777, 567}; 
        int count = 0;
        for (int i = 0; i < ContArray.Length; i++)
        {
            if(ContArray[i] % 2 == 0)
            {
                count = count + 1;
            }
        }
        System.Console.WriteLine($"Чётных чисел в массиве {count}");
    
}

if(TaskIndex == 4)
{
    int[] array = {3, 7, 11, 9, 13};
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            count = count + array[i]; 
        }   
    }
    System.Console.WriteLine($"Сумма чисоел нечётных элементов массива - {count}");
}
if(TaskIndex == 5)
{
     int[] array = {18, 22, 36, 90};
     int diff = array[array.Length-1] - array[0];
     System.Console.WriteLine($"Разность между максимальным и минимальным элементом массива - {diff}");

}

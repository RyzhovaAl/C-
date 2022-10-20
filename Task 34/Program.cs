// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i< size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue +1);
    }
    return res; 
}

// void PrintArray(int[] massive)
// {
//     int count = massive.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(massive[position]);
//         position++;
//     }
// }

int GetCount(int[] numArray)
{
    int count = 0; 
    for (int i =0; i < numArray.Length; i++)
    {
        
        if(numArray[i] > 99 && numArray[i] < 1000)
        {
            if(numArray[i] % 2 == 0)
            {
                count += 1; 
            }
        }
    }
    return count; 
}

Console.Clear();
int[] array = GetArray(4, 100, 999);
Console.WriteLine(String.Join(", ", array));
Console.Write($"Количество четных элементов в массиве равно: {GetCount(array)}");
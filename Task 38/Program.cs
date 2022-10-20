// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i< size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue +1);
    }
    return res; 
}

double GetDiff(double[] numArray)
{
    double max = numArray[0]; 
    double min = numArray[0]; 
    double diff = 0; 
    for (int i = 0; i < numArray.Length; i++)
    {
        
        if(numArray[i] > max)
        {
            max = numArray[i];
        }
        else if(numArray[i] < min)
        {
            min = numArray[i];
        }
        diff = max - min; 
    }
    return diff; 
}

Console.Clear();
double[] array = GetArray(4, -100, 100);
Console.WriteLine(String.Join(", ", array));
Console.Write($"Разница между максимальным и минимальным элементами массива равна: {GetDiff(array)}");
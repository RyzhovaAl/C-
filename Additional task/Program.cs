// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. 
// Реализовать невозрастающую сторировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i< size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue +1);
    }
    return res; 
}

int[] BubbleSort(int[] massive)
{
    int temp;
    for (int i = 0; i < massive.Length; i++)
    {
        for (int j = i + 1; j < massive.Length; j++)
        {
            if(massive[i] < massive[j])
            {
                temp = massive[i];
                massive[i] = massive[j];
                massive[j] = temp;
            }
        }
    }
    return massive;
}

Console.Clear();
int[] array = GetArray(5, -100, 100);
Console.WriteLine(String.Join(", ", array));
BubbleSort(array);
Console.WriteLine(String.Join(", ", array));
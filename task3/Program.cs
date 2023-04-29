// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int length, int minRnd, int maxRnd)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minRnd, maxRnd + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int findMax(int[] array)
{
    int result = array[0];
    for(int i = 0; i < array.Length; i++)
        if(array[i] > result)
            result = array[i];
    return result;
}

int findMin(int[] array)
{
    int result = array[0];
    for(int i = 0; i < array.Length; i++)
        if(array[i] < result)
            result = array[i];
    return result;
}

int getMaxMinusMin(int min, int max)
{
    return max - min;
}

int arrayLength = ReadInt("Enter array size");
int minValue = ReadInt("Enter minimum value");
int maxValue = ReadInt("Enter maximum value");
int[] myArray = CreateArray(arrayLength, minValue, maxValue);
PrintArray(myArray);
int min = findMin(myArray);
int max = findMax(myArray);
int maxMinusMin = getMaxMinusMin(min, max);
Console.WriteLine($"The difference of minimal ({min}) and maximal ({max}) numbers of array is {maxMinusMin}");
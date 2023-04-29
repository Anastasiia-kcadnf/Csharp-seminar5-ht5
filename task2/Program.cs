// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumOfNumbersNonEvenPositions(int[] array)
{
    int result = 0;
    if(array.Length > 1)
        for(int i = 1; i < array.Length; i += 2)
            result += array[i];
    return result;
}

int arrayLength = ReadInt("Enter the array size");
int minValue = ReadInt("Enter minimum value");
int maxValue = ReadInt("Enter maximum value");
int[] myArray = CreateArray(arrayLength, minValue, maxValue);
PrintArray(myArray);
int sum = SumOfNumbersNonEvenPositions(myArray);
Console.WriteLine("Sum of numbers on non-even positions in array - " + sum);
// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

 int count = 0;
int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,1000);
        if (array[i] % 2==0)
        {
            count++;
        }
    }
    return array;
}
int[] array = GetArray(6);

Console.WriteLine(String.Join(", ",array));

Console.WriteLine("Количество чётных чисел в массиве: " +count);
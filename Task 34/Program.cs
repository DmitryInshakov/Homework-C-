// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int [] CreateArrayThreeDigit (int sizeCollection)
{
    int [] collection = new int [sizeCollection];
    Random rnd = new Random();
    int min = 100;
    int max = 1000; 
    for (int i = 0; i < sizeCollection; i++)
    {
        collection[i] = rnd.Next (min,max);
    }
    return collection;
}

int EvenNumbers (int [] massiv)
{
    int counter = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i] % 2 == 0)
        {
            counter ++;
        }
    }
    return counter;
}

void PrintArray (int [] mas)
{
    Console.Write("[");
    for (int i = 0; i < mas.Length - 1; i++)
    {
        Console.Write($"{mas[i]}, ");
    }
    Console.Write($"{mas[mas.Length-1]}");
    Console.Write($"] -> {EvenNumbers(mas)}");
}

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArrayThreeDigit(size);
PrintArray (array);







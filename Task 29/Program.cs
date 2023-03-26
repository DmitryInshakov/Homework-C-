// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void CreateArray (int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next (1,100);
    }
}

void PrintArray (int [] mas)
{
    Console.Write("[");
    for (int i = 0; i < mas.Length - 1; i++)
    {
        Console.Write($"{mas[i]}, ");
    }
    Console.Write($"{mas[mas.Length-1]}");
    Console.Write("]");
}

int [] array = new int [8];
CreateArray(array);
PrintArray(array);





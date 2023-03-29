//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] CreateMassif (int sizeMassif, int minrnd, int maxrnd)
{
    double [] massif = new double [sizeMassif];
    Random rnd = new Random(); 
    for (int i = 0; i < sizeMassif; i++)
    {
        massif[i] = rnd.Next (minrnd,maxrnd + 1) + rnd.NextDouble();
    }
    return massif;
}

double FindMaxNumber (double [] arrayMax)
{
    double max = arrayMax[0];
    for (int i = 0; i < arrayMax.Length; i++)
    {
        if (arrayMax[i] > max)
        {
            max = arrayMax[i];
        }
    }
    return max;
}

double FindMinNumber (double [] arrayMin)
{
    double min = arrayMin[0];
    for (int i = 0; i < arrayMin.Length; i++)
    {
        if (arrayMin[i] < min)
        {
            min = arrayMin[i];
        }
    }
    return min;
}

void PrintArray (double [] mas)
{
    Console.Write("[");
    for (int i = 0; i < mas.Length - 1; i++)
    {
        Console.Write($"{Math.Round(mas[i],2,MidpointRounding.ToZero)}; ");
    }
    Console.Write($"{Math.Round((mas[mas.Length-1]),2,MidpointRounding.ToZero)}");
    double difference = FindMaxNumber(mas) - FindMinNumber(mas);
    Console.Write($"] -> {Math.Round(difference,2,MidpointRounding.ToZero)}");
}

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size < 0 || size == 0)
{
    Console.WriteLine("Вы ввели неверное число (размер массива от 1 и более)");
}
else
{
    Console.Write("Введите начальное значение для диапазона случайного числа: ");
    int minRandom = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конечное значение для диапазона случайного числа: ");
    int maxRandom = Convert.ToInt32(Console.ReadLine());
    double [] array = CreateMassif(size,minRandom,maxRandom);
    PrintArray(array);
}



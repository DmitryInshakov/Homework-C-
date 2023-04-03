// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int [] InputArray (int sizeArray)
{
    int [] arrayGet = new int [sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        Console.Write ($"Введите {i+1} элемент: ");
        arrayGet[i]= Convert.ToInt32(Console.ReadLine());
    }
    return arrayGet;
}

int PositiveNumberArray (int [] mas)
{
    int counter = 0;
    for (int i = 0 ; i < mas.Length; i++)
    {
        if (mas [i] > 0)
        {
            counter ++;
        }
    }
    return counter;
}

void PrintArray (int [] massif)
{
    Console.Write("[");
    for (int i = 0; i < massif.Length; i++)
    {
        Console.Write($"{massif[i]}, ");
    }
    Console.Write($"{massif[massif.Length-1]}");
    Console.Write($"] -> {PositiveNumberArray(massif)}");
}

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size < 0 || size == 0)
{
    Console.WriteLine("Вы ввели неверное число (размер массива от 1 и более)");
}
else
{
    int [] array = InputArray(size);
    PrintArray(array);
}

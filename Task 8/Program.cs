// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int n = Convert.ToInt32(Console.ReadLine());
int counter = 1;
while (counter<=n)
{
    if (counter%2==0)
    {
        Console.Write(counter);
        Console.Write(" ");
    }
    counter+=1;
}


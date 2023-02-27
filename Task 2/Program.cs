/*Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.*/

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write("max = ");
    Console.WriteLine(a);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(b);  
}

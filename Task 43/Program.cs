// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

const int index = 0;
const int permanent = 1;
const int x = 0;
const int y = 1;
const int line1 = 1;
const int line2 = 2;

double [] InputDataLines (int numberLine)
{
    double[] dataLines = new double [2];
    Console.Write ("Введите коэффициент перед x: ");
    dataLines[index] = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Введите постоянную составляющую: ");
    dataLines[permanent] =  Convert.ToInt32 (Console.ReadLine());
    return dataLines;
}

 double[] FindPoints (double[] lineValue1, double[] lineValue2)
{
    double [] points = new double [2];
    points[x] = (lineValue1[permanent] - lineValue2[permanent])/(lineValue2[index]-lineValue1[index]);
    points[y] = lineValue1[index] * points[x] + lineValue1[permanent];
    return points;
}

double [] lineData1 = InputDataLines(line1);
double [] lineData2 = InputDataLines(line2);

if (lineData1[index]==lineData2[index])
{
    if(lineData1[permanent]==lineData2[permanent])
    {
        Console.WriteLine ("Прямые совпадают");
    }
    else
    {
        Console.WriteLine ("Прямые параллельны");
    }
}
else
{
    double[] pointsLine = FindPoints(lineData1,lineData2);
    Console.WriteLine($"b1 = {lineData1[1]}, k1 = {lineData1[0]} : b2 = {lineData2[1]}, k2 = {lineData2[0]} -> ({pointsLine[x]}; {pointsLine[y]})");
}


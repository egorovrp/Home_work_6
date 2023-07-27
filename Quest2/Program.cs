// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

double Prompt(string message)
{
    Console.Write(message);
    double result = double. Parse(Console.ReadLine()!);
    return result;
}

double SearchX(double a, double b, double c, double d)
{
    double x = (a-b)/(c-d);
    return x;
}

double SearchY(double a, double b, double c)
{
     double y = a*b+c;
    return y;
}

double b1 = Prompt("Введите коэффициент b1 первой прямой: ");
double k1 = Prompt("Введите коэффициент k1 первой прямой: ");
double b2 = Prompt("Введите коэффициент b2 второй прямой: ");
double k2 = Prompt("Введите коэффициент k2 второй прямой: ");

double X = SearchX(b2,b1,k1,k2);
double Y = SearchY(k1,X,b1);

Console.WriteLine($"Точка пересечения двух прямых: ({X},{Y})");


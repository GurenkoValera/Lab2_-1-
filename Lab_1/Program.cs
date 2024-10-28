using System;

class Program
{
    static void Main()
    {
        // Ввод коэффициентов a, b и c
        Console.WriteLine("Введите коэффициенты для квадратного уравнения ax^2 + bx + c = 0:");

        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Вычисление дискриминанта
        double discriminant = b * b - 4 * a * c;

        // Проверка дискриминанта и вычисление корней
        if (discriminant > 0)
        {
            // Два действительных корня
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Два действительных корня: x1 = {x1}, x2 = {x2}");
        }
        else if (discriminant == 0)
        {
            // Один действительный корень
            double x = -b / (2 * a);
            Console.WriteLine($"Один действительный корень: x = {x}");
        }
        else
        {
            // Комплексные корни
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
            Console.WriteLine($"Комплексные корни: x1 = {realPart} + {imaginaryPart}i, x2 = {realPart} - {imaginaryPart}i");
        }
    }
}

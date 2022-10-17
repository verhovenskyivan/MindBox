public class Triangle
{
    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double A { get; }
    public double B { get; }
    public double C { get; }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите сторону A: ");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите сторону B: ");
        double B = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите сторону C: ");
        double C = Convert.ToDouble(Console.ReadLine());


        double P = (A + B + C) / 2;

        double S = Math.Sqrt(P * (P - A) * (P - B) * (P - C));

        if (A * A + B * B == C * C)
        {
            Console.WriteLine("Треугольник является прямоугольным");
        }
        else
        {
            Console.WriteLine("Треугольник не является прямоугольным");
        }

            Console.WriteLine("Площадь данного треугольника: " + S);
    }

    public object GetSquare()
    {
        throw new NotImplementedException();
    }
}
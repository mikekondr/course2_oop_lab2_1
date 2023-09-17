namespace task9;

public class Triangle
{
    private double a, b, c;

    //сеттер (властивість) для задання значення поля a
    public double A
    {
        set
        {
            if (value > 0) a = value;
            else Console.WriteLine("Сторона A має бути більше нуля!");
        }
    }

    //сеттер (властивість) для задання значення поля b
    public double B
    {
        set
        {
            if (value > 0) b = value;
            else Console.WriteLine("Сторона B має бути більше нуля!");
        }
    }

    //сеттер (властивість) для задання значення поля c
    public double C
    {
        set
        {
            if (value > 0) c = value;
            else Console.WriteLine("Сторона C має бути більше нуля!");
        }
    }

    //метод для перевірки існування обʼєкта
    public bool Correct()
    {
        bool result = (a < b + c && b < a + c && c < a + b);
        return result;
    }

    //метод для виводу на екран значень полів
    public void Print() => Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

    //метод для обчислення периметру
    public double Perimetr() => a + b + c;

    //метод для обчислення кутів трикутника
    public void Corners(out double alfa, out double beta, out double gamma)
    {
        alfa = Math.Acos((b * b + c * c - a * a) / (2 * b * c) ) * 180 / Math.PI;
        beta = Math.Acos((a * a + c * c - b * b) / (2 * a * c) ) * 180 / Math.PI;
        gamma = 180 - alfa - beta;
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            //створення обʼєкта з нуьовими полями
            Triangle t = new Triangle();

            Console.WriteLine("\tОбчислення трикутника\n");
            Console.WriteLine("Введіть довжини сторін трикутника:");

            //введення сторін трикутника
            Console.Write("a = "); t.A = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = "); t.B = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = "); t.C = Convert.ToDouble(Console.ReadLine());

            //вивід на екран значень полів
            Console.Write("\nТрикутник зі сторонами:");
            t.Print();

            //перевірка існування обʼєкта
            if (t.Correct()) //обʼєкт існує
            {
                //виклик методу для обчислення периметра
                Console.WriteLine("Периметр трикутника: Р = {0:f3}", t.Perimetr());

                //виклик методу для обчислення кутів
                double alfa, beta, gamma;
                t.Corners(out alfa, out beta, out gamma);
                Console.WriteLine("Кути трикутника: α = {0:f2}°, β = {1:f2}° γ = {2:f2}°",
                    alfa, beta, gamma);
            }
            //обʼєкт не існує
            else Console.WriteLine("Такий трикутник не існує!");
        }
        catch
        {
            //усі інші помилки
            Console.WriteLine("Помилка!");
        }
    }
}
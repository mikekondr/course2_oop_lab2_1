namespace example;

public class Triangle
{
    private double a, b, c;

    //сеттер (властивість) для задання значення поля a
    public double A
    {
        set
        {
            if (value > 0) a = value;
            else Console.WriteLine("Сторона A не може бути відʼємною!");
        }
    }

    //сеттер (властивість) для задання значення поля b
    public double B
    {
        set
        {
            if (value > 0) b = value;
            else Console.WriteLine("Сторона B не може бути відʼємною!");
        }
    }

    //сеттер (властивість) для задання значення поля c
    public double C
    {
        set
        {
            if (value > 0) c = value;
            else Console.WriteLine("Сторона C не може бути відʼємною!");
        }
    }

    //метод для перевірки існування обʼєкта
    public bool Correct()
    {
        bool result = false;
        if (a < b + c && b < a + c && c < a + b) result = true;
        return result;
    }

    //метод для виводу на екран значень полів
    public void Print() => Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);

    //метод для обчислення периметру
    public double Perimetr() => a + b + c;

    //метод для обчислення площі
    public double Sqrt()
    {
        double p = this.Perimetr() / 2;
        return Math.Sqrt(p * (p-a) * (p-b) * (p-c));
    }
}

class Program
{
    static void Main(string[] args)
    {
        double x, y, z;

        try
        {
            //введення сторін трикутника
            Console.Write("a = "); x = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = "); y = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = "); z = Convert.ToDouble(Console.ReadLine());

            //створення обʼєкта з нуьовими полями
            Triangle t = new Triangle();
            //встановлення значень полів за допомогою сеттерів (властивостей)
            t.A = x; t.B = y; t.C = z;
            //вивід на екран значень полів
            t.Print();

            //перевірка існування обʼєкта
            if (t.Correct()) //обʼєкт існує
            {
                //виклик методів для обчислення периметра та площі
                double p = t.Perimetr();
                double s = t.Sqrt();
                //вивід результатів
                Console.WriteLine("P = {0:f3}, S = {1:f3}", p, s);
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


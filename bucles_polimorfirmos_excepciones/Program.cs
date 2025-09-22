

abstract class Figura
{
    public abstract double Area();
    public abstract double Perimetro();
}

interface IExtraCalculations
{
    double Add10();
}

class Circulo : Figura, IExtraCalculations
{
    public double Radio { get; set; }

    public override double Area() => Math.PI * Radio * Radio;

    public override double Perimetro() => 2 * Math.PI * Radio;

    public double Add10()
    {
        return Radio + 10;
    }
}

class Program
{
    static void Main()
    {
        var circ = new Circulo();
        circ.Radio = 20;

        var result_area = circ.Area();
        var result_perim = circ.Perimetro();

        Console.WriteLine($"El área es: {result_area} y el perímetro es: {result_perim}");
        Console.WriteLine($"El radio + 10 es: {circ.Add10()}");

        // Bucle Fibonacci
        int prev = 0, next = 1, sum = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(prev);
            sum = prev + next;
            prev = next;
            next = sum;
        }
        
         // --- Excepciones División ---
        try
        {
            Console.WriteLine("\nNúmero a dividir:");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("Divisor:");
            double divisor = double.Parse(Console.ReadLine());

            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }

            Console.WriteLine($"Resultado: {n / divisor}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("No se puede dividir por cero!");
        }
        catch (Exception)
        {
            Console.WriteLine("Error desconocido.");
        }
    }
}

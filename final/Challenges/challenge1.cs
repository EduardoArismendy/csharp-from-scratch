

namespace itm.csharp.basic
{
    // 1. Determinar si un número es positivo, negativo o cero
    public class Challenge1
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            int num = int.Parse(Console.ReadLine());
            if (num > 0) Console.WriteLine("Positivo");
            else if (num < 0) Console.WriteLine("Negativo");
            else Console.WriteLine("Cero");
        }
    }

    // 2. Operaciones básicas con dos números
    public class Challenge2
    {
        public void Run()
        {
            Console.WriteLine("Ingrese primer número:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Suma: {num1 + num2}");
            Console.WriteLine($"Resta: {num1 - num2}");
            Console.WriteLine($"Multiplicación: {num1 * num2}");
            if (num2 != 0)
                Console.WriteLine($"División: {num1 / num2}");
            else
                Console.WriteLine("No se puede dividir entre 0");
        }
    }

    // 3. Área y perímetro de un rectángulo
    public class Challenge3
    {
        public void Run()
        {
            Console.WriteLine("Ingrese la base del rectángulo:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectángulo:");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine($"Área: {b * h}");
            Console.WriteLine($"Perímetro: {2 * (b + h)}");
        }
    }

    // 4. Mayor de tres números
    public class Challenge4
    {
        public void Run()
        {
            Console.WriteLine("Ingrese tres números:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double mayor = Math.Max(a, Math.Max(b, c));
            Console.WriteLine($"El mayor es: {mayor}");
        }
    }

    // 5. Factorial
    public class Challenge5
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            int n = int.Parse(Console.ReadLine());
            long fact = 1;
            for (int i = 1; i <= n; i++) fact *= i;
            Console.WriteLine($"Factorial: {fact}");
        }
    }

    // 6. Conversión Celsius a Fahrenheit
    public class Challenge6
    {
        public void Run()
        {
            Console.WriteLine("Ingrese grados Celsius:");
            double c = double.Parse(Console.ReadLine());
            double f = (c * 9 / 5) + 32;
            Console.WriteLine($"{c} °C = {f} °F");
        }
    }

    // 7. Par o impar
    public class Challenge7
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 2 == 0 ? "Par" : "Impar");
        }
    }

    // 8. Operaciones con fracciones
    public class Challenge8
    {
        public void Run()
        {
            Console.WriteLine("Ingrese numerador y denominador de la primera fracción:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numerador y denominador de la segunda fracción:");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine($"Suma: {(a * d + b * c)}/{b * d}");
            Console.WriteLine($"Resta: {(a * d - b * c)}/{b * d}");
            Console.WriteLine($"Multiplicación: {(a * c)}/{(b * d)}");
            Console.WriteLine($"División: {(a * d)}/{(b * c)}");
        }
    }

    // 9. Tabla de multiplicar
    public class Challenge9
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }

    // 10. Números primos del 1 al 100
    public class Challenge10
    {
        public void Run()
        {
            for (int i = 2; i <= 100; i++)
            {
                bool primo = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                    if (i % j == 0) { primo = false; break; }

                if (primo) Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }

    // 11. Validar números válidos (ejemplo: positivos)
    public class Challenge11
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int n) && n > 0)
                Console.WriteLine("Número válido.");
            else
                Console.WriteLine("Número inválido.");
        }
    }

    // 12. Categorizar notas
    public class Challenge12
    {
        public void Run()
        {
            Console.WriteLine("Ingrese una nota (0 a 5):");
            double nota = double.Parse(Console.ReadLine());
            if (nota < 3) Console.WriteLine("Reprobado");
            else if (nota < 4) Console.WriteLine("Aprobado");
            else Console.WriteLine("Excelente");
        }
    }

    // 13. Agenda: agregar contacto
    public class Challenge13
    {
        public void Run()
        {
            Console.WriteLine("Ingrese nombre del contacto:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese número telefónico:");
            string telefono = Console.ReadLine();
            Console.WriteLine($"Contacto agregado: {nombre} - {telefono}");
        }
    }

    // 14. Agenda: búsqueda
    public class Challenge14
    {
        public void Run()
        {
            Console.WriteLine("Función de búsqueda de contactos (simulada).");
        }
    }

    // 15. Cargar base de datos (simulada)
    public class Challenge15
    {
        public void Run()
        {
            Console.WriteLine("Base de datos cargada correctamente (simulada).");
        }
    }

    // 16. Mostrar base de datos (simulada)
    public class Challenge16
    {
        public void Run()
        {
            Console.WriteLine("Mostrando base de datos (simulada).");
        }
    }
}

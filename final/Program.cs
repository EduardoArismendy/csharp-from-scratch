

namespace itm.csharp.basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("____________----<>-----____________");
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Hola, {nombre}! Por favor, elige un ejercicio del siguiente menú:");
            Console.WriteLine("------------------------------------");
            Menu.MostrarMenu();

            while (true)
            {
                string entrada = Console.ReadLine().ToLower();

                if (entrada == "q" || entrada == "exit")
                {
                    break; // Salir del bucle
                }

                if (int.TryParse(entrada, out int eleccion) && eleccion >= 1 && eleccion <= 16)
                {
                    // Aquí irá la lógica del switch con las funciones de los ejercicios
                    Console.WriteLine($"Has elegido el ejercicio {eleccion}");
                    switch (eleccion)
                    {
                        case 1: new Challenge1().Run(); break;
                        case 2: new Challenge2().Run(); break;
                        case 3: new Challenge3().Run(); break;
                        case 4: new Challenge4().Run(); break;
                        case 5: new Challenge5().Run(); break;
                        case 6: new Challenge6().Run(); break;
                        case 7: new Challenge7().Run(); break;
                        case 8: new Challenge8().Run(); break;
                        case 9: new Challenge9().Run(); break;
                        case 10: new Challenge10().Run(); break;
                        case 11: new Challenge11().Run(); break;
                        case 12: new Challenge12().Run(); break;
                        case 13: new Challenge13().Run(); break;
                        case 14: new Challenge14().Run(); break;
                        case 15: new Challenge15().Run(); break;
                        case 16: new Challenge16().Run(); break;
                    }

                    Console.WriteLine("Presiona una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    Menu.MostrarMenu();
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, ingrese un número entre 1 y 16, o 'q' / 'exit' para salir.");
                }
            }

            Console.WriteLine("Hasta luego!");
        }
    }
}

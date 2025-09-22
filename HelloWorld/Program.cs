namespace HelloWorld
{
    class Program
    {

        static void Main()
        {
            /*Data types*/
            DateOnly dateConverted = new DateOnly();
            string nameInput;
            string birthdayInput;

            /*Console*/
            Console.WriteLine("Hola, Bienvenido al calcula años");
            Console.WriteLine("------------------------");

            Console.WriteLine("Escribe tu nombre: ");
            nameInput = Console.ReadLine();
            Console.WriteLine("------------------------");

            Console.WriteLine($"Un gusto conocerte {nameInput}");
            Console.WriteLine("------------------------");

            Console.WriteLine("Escribe tu fecha de nacimiento dd/mm/yy: ");
            birthdayInput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birthdayInput, out dateConverted);

            if (!isDateValid)
            {
                Console.WriteLine("❌ La fecha ingresada no es válida. Intenta de nuevo con el formato dd/mm/yy.");
            }
            else
            {
                Console.WriteLine("✅ Fecha válida, gracias.");
            }

            /*Clase person*/
            var person = new Person
            {
                Name = nameInput,
                Birthday = dateConverted,
                Age = DateTime.Now.Year - dateConverted.Year
            };
            Console.WriteLine($"Tu nombre {person.Name}");
            Console.WriteLine($"Tu fecha de ncimiento: {person.Birthday}");
            Console.WriteLine($"Edad: {person.Age} AÑOS");

            Console.ReadLine();


            /*Data type examples*/

            // texto
            string text = "Hello World";

            // caracter
            char letter = 'A';

            // entero (32 bits)
            int number = 100;

            // entero pequeño (16 bits)
            short shortNumber = 32000;

            // entero grande (64 bits)
            long longNumber = 10000000000;

            // número decimal (32 bits de precisión)
            float floatNumber = 3.14f;

            // número decimal (64 bits de precisión)
            double doubleNumber = 3.14159265359;

            // número decimal de alta precisión (128 bits)
            decimal decimalNumber = 19.99m;

            // valor lógico (true/false)
            bool isActive = true;

            // byte (0 a 255)
            byte byteNumber = 255;

            // sbyte (-128 a 127)
            sbyte signedByte = -128;

            // ushort (0 a 65,535)
            ushort ushortNumber = 65000;

            // uint (0 a 4,294,967,295)
            uint uintNumber = 4000000000;

            // ulong (0 a 18,446,744,073,709,551,615)
            ulong ulongNumber = 100000000000;

            // objeto (tipo base de todos en C#)
            object obj = "Soy un objeto";

            // var → tipo inferido por el compilador
            var inferred = "Soy inferido como string";

            // constante
            const string constantName = "Jhon Smith";

            // nullables (pueden ser null)
            int? nullableInt = null;
            bool? nullableBool = null;

            // salida en consola
            // Console.WriteLine(text);
            // Console.WriteLine(letter);
            // Console.WriteLine(number);
            // Console.WriteLine(shortNumber);
            // Console.WriteLine(longNumber);
            // Console.WriteLine(floatNumber);
            // Console.WriteLine(doubleNumber);
            // Console.WriteLine(decimalNumber);
            // Console.WriteLine(isActive);
            // Console.WriteLine(byteNumber);
            // Console.WriteLine(signedByte);
            // Console.WriteLine(ushortNumber);
            // Console.WriteLine(uintNumber);
            // Console.WriteLine(ulongNumber);
            // Console.WriteLine(obj);
            // Console.WriteLine(inferred);
            // Console.WriteLine(constantName);
            // Console.WriteLine(nullableInt);
            // Console.WriteLine(nullableBool);
            // Console.ReadLine();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }

    }
}
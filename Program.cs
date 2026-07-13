using System;

namespace RegistroEstudiante
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constante: número máximo de materias permitidas
            const int MaximoMaterias = 6;

            // Captura de datos
            Console.Write("Ingrese su nombre completo: ");
            string nombreCompleto = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese su carrera: ");
            string carrera = Console.ReadLine();

            Console.Write("Ingrese su carné o código de estudiante: ");
            string carnet = Console.ReadLine();

            Console.Write("Ingrese su correo electrónico: ");
            string correo = Console.ReadLine();

            Console.Write("Ingrese su número de teléfono: ");
            string telefono = Console.ReadLine();

            Console.Write("Ingrese su promedio actual: ");
            double promedio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el número de materias inscritas: ");
            int materiasInscritas = Convert.ToInt32(Console.ReadLine());

            // Procesamiento
            int edadEnCincoAnios = edad + 5;
            bool puedeInscribirMas = materiasInscritas < MaximoMaterias;

            // Salida de información
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine($"¡Bienvenido/a, {nombreCompleto}!");
            Console.WriteLine("========================================");

            Console.WriteLine();
            Console.WriteLine("----- RESUMEN DEL ESTUDIANTE -----");
            Console.WriteLine($"Nombre completo:        {nombreCompleto}");
            Console.WriteLine($"Edad actual:            {edad} años");
            Console.WriteLine($"Edad dentro de 5 años:  {edadEnCincoAnios} años");
            Console.WriteLine($"Carrera:                {carrera}");
            Console.WriteLine($"Carné:                  {carnet}");
            Console.WriteLine($"Correo electrónico:     {correo}");
            Console.WriteLine($"Teléfono:               {telefono}");
            Console.WriteLine($"Promedio actual:        {promedio}");
            Console.WriteLine($"Materias inscritas:     {materiasInscritas}");
            Console.WriteLine($"Límite de materias:     {MaximoMaterias}");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine();
            if (puedeInscribirMas)
            {
                int disponibles = MaximoMaterias - materiasInscritas;
                Console.WriteLine($"El estudiante puede inscribir {disponibles} materia(s) más.");
            }
            else
            {
                Console.WriteLine("El estudiante ha alcanzado el máximo de materias permitidas.");
            }

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
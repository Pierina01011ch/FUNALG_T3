using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citasApp
{
    public class Cita
    {
        public int Numero { get; set; }
        public Estudiante Estudiante { get; set; }
        public string Enfermedad { get; set; }
        public double Precio { get; set; }

        public override string ToString()
        {
            return $"Cita #{Numero} | Enfermedad: {Enfermedad} | Estudiante: {Estudiante.Nombre} | Universidad: {Estudiante.Universidad} | Precio: s/.{Precio:0.00}";
        }
    }

    public static class CitaUtil
    {
        public static void CrearCita(List<Cita> citas)
        {
            Console.WriteLine("\nCrear nueva Cita:");

            Estudiante estudiante = new Estudiante();
            Console.Write("Introduzca el código del estudiante: ");
            estudiante.Codigo = int.Parse(Console.ReadLine());
            Console.Write("Introduzca el nombre del estudiante: ");
            estudiante.Nombre = Console.ReadLine();
            Console.Write("Introduzca la universidad del estudiante: ");
            estudiante.Universidad = Console.ReadLine();

            Cita cita = new Cita();
            cita.Numero = citas.Count + 1;  
            cita.Estudiante = estudiante;
            Console.Write("Introduzca la enfermedad que padece: ");
            cita.Enfermedad = Console.ReadLine();
            Console.Write("Introduzca el precio de la cita: ");
            cita.Precio = double.Parse(Console.ReadLine());

            citas.Add(cita);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cita creada con éxito.");
            Console.ResetColor();
        }

        public static void ListarCitas(List<Cita> citas)
        {
            Console.WriteLine("\nListado de Citas:");
            double sumaPrecios = 0;

            if (citas.Count > 0)
            {
                Console.WriteLine("Número | Enfermedad | Estudiante | Universidad | Precio");
                foreach (var cita in citas)
                {
                    Console.WriteLine(cita);
                    sumaPrecios += cita.Precio;
                }

                Console.WriteLine($"\nSuma total de los precios: ${sumaPrecios:0.00}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No hay citas registradas.");
                Console.ResetColor();
            }
        }

        public static void ModificarUniversidadesMasivamente(List<Cita> citas)
        {
            Console.Write("\nIntroduzca el texto a buscar y modificar en las universidades: ");
            string textoBuscar = Console.ReadLine();

            Console.Write("Introduzca el nuevo texto para las universidades: ");
            string textoNuevo = Console.ReadLine();

            bool modificado = false;
            foreach (var cita in citas)
            {
                if (cita.Estudiante.Universidad.Contains(textoBuscar))
                {
                    cita.Estudiante.Universidad = cita.Estudiante.Universidad.Replace(textoBuscar, textoNuevo);
                    modificado = true;
                }
            }

            if (modificado)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Universidades modificadas con éxito.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No se encontraron universidades con el texto proporcionado.");
                Console.ResetColor();
            }
        }
    }

}

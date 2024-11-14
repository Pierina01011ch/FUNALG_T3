using citasApp;

List<Cita> citas = new List<Cita>();  
bool continuar = true;

while (continuar)
{
    Console.Clear();
    Console.WriteLine("===Menú de Citas Médicas===");
    Console.WriteLine("1. Crear Cita");
    Console.WriteLine("2. Listar Citas");
    Console.WriteLine("3. Modificar Universidades Masivamente");
    Console.WriteLine("4. Fin");
    Console.Write("Selecciona una opción: ");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            CitaUtil.CrearCita(citas);
            break;
        case "2":
            CitaUtil.ListarCitas(citas);
            break;
        case "3":
            CitaUtil.ModificarUniversidadesMasivamente(citas);
            break;
        case "4":
            continuar = false;
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opción inválida. Por favor seleccione una opción válida.");
            Console.ResetColor();
            break;
    }

    if (continuar)
    {
        Console.Write("\n¿Deseas regresar al menú? [si] para continuar: ");
        string respuesta = Console.ReadLine().ToLower();
        if (respuesta != "si")
        {
            continuar = false;
        }
    }
}

Console.WriteLine("¡Adiós!");


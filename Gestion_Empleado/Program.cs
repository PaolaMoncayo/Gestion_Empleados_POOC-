using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Empleado> empleados = new List<Empleado>();
        List<Gerente> gerentes = new List<Gerente>();

        int opcion;
        do
        {
            Console.WriteLine("\n------------------- Menú -------------------");
            Console.WriteLine("1. Ingresar datos del empleado");
            Console.WriteLine("2. Ingresar datos del gerente");
            Console.WriteLine("3. Mostrar información generada");
            Console.WriteLine("4. Salir");
            Console.Write("Ingrese la opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            Console.Clear(); // Limpiar la pantalla antes de mostrar nueva información

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nIngrese los datos del empleado:");
                    Console.Write("Nombre: ");
                    string nombreEmpleado = Console.ReadLine();
                    Console.Write("Salario: ");
                    double salarioEmpleado = Convert.ToDouble(Console.ReadLine());

                    empleados.Add(new Empleado(nombreEmpleado, salarioEmpleado));
                    break;

                case 2:
                    Console.WriteLine("\nIngrese los datos del gerente:");
                    Console.Write("Nombre: ");
                    string nombreGerente = Console.ReadLine();
                    Console.Write("Salario: ");
                    double salarioGerente = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Departamento: ");
                    string departamentoGerente = Console.ReadLine();

                    gerentes.Add(new Gerente(nombreGerente, salarioGerente, departamentoGerente));
                    break;

                case 3:
                    Console.WriteLine("\n------------------------------------------------");
                    Console.WriteLine("\nInformación de los empleados:");
                    foreach (var empleado in empleados)
                    {
                        empleado.MostrarInformacion();
                    }

                    Console.WriteLine("\n------------------------------------------------");
                    Console.WriteLine("\nInformación de los gerentes:");
                    foreach (var gerente in gerentes)
                    {
                        gerente.MostrarInformacion();
                    }
                    Console.WriteLine("\n------------------------------------------------");

                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa.");
                    break;

                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }

        } while (opcion != 4);
    }
}
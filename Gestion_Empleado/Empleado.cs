using System;

// Definición de la clase Empleado (clase base)
public class Empleado : IMostrarInformacion
{
    //Atributos
    public string Nombre { get; set; }
    public double Salario { get; set; }

    //Constructor de la clase Empleado
    public Empleado(string nombre, double salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    //Metodo
    public double CalcularSalarioAnual()
    {
        return Salario * 12; // Salario mensual
    }

    //Metodo que implementa la función de la interfaz
    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"\nEmpleado: {Nombre}");
        Console.WriteLine($"Salario: {Salario:C}");
        Console.WriteLine($"Salario Anual: {CalcularSalarioAnual():C}");
    }
}

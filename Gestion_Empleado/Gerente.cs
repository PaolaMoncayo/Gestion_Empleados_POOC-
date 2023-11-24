using System;

// Definición de la clase Gerente que hereda de Empleado
public class Gerente : Empleado, IMostrarInformacion
{
    //Atributo
    public string Departamento { get; set; }

    //Constructor de la clase Gerente
    public Gerente(string nombre, double salario, string departamento)
        : base(nombre, salario)
    {
        Departamento = departamento;
    }

    //Metodo que implementa la función de la interfaz
    public override void MostrarInformacion()
    {
        Console.WriteLine($"Gerente: {Nombre}");
        Console.WriteLine($"Salario: {Salario:C}");
        Console.WriteLine($"Salario Anual: {CalcularSalarioAnual():C}");
        Console.WriteLine($"Departamento: {Departamento}");
    }
}
using System;

class Tareas : Evaluacion
{
    private string nombre;
    private DateTime fecha;

    public Tareas(double nota, string nombre, DateTime fecha) : base(nota)
    {
        this.nombre = nombre;
        this.fecha = fecha;
    }

    public override void mostrarDetalles()
    {
        Console.WriteLine("Nota de la tarea: {0}", getNota());
        Console.WriteLine("Nombre de la tarea: {0}", nombre);
        Console.WriteLine("Fecha: {0}", fecha.ToString("dd/MM/yyyy"));
    }
}

using System;

class Examen : Evaluacion
{
    private string nombre;
    private double notaMaxima;
    private DateTime fecha;

    public Examen(double nota, string nombre, double notaMaxima, DateTime fecha) : base(nota)
    {
        this.nombre = nombre;
        this.notaMaxima = notaMaxima;
        this.fecha = fecha;
    }

    public override void mostrarDetalles()
    {
        Console.WriteLine("Examen: {0}", nombre);
        Console.WriteLine("Nota del examen: {0}/{1}", getNota(), notaMaxima);
        Console.WriteLine("Fecha: {0}", fecha.ToString("dd/MM/yyyy"));
    }
}

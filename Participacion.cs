using System;

class Participacion : Evaluacion
{
    private string detalles;

    public Participacion(double nota, string detalles) : base(nota)
    {
        this.detalles = detalles;
    }

    public override void mostrarDetalles()
    {
        Console.WriteLine("Nota de la participacion: {0}", getNota());
        Console.WriteLine("Detalles: {0}", detalles);
    }
}

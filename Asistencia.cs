using System;

class Asistencia : Evaluacion
{
    private int asistenciaAlumno;
    private int asistenciaTotal;

    public Asistencia(double nota, int asistenciaAlumno, int asistenciaTotal) : base(nota)
    {
        this.asistenciaAlumno = asistenciaAlumno;
        this.asistenciaTotal = asistenciaTotal;
    }

    public override void mostrarDetalles()
    {
        Console.WriteLine("Asistencia: {0}/{1}", asistenciaAlumno, asistenciaTotal);
        Console.WriteLine("Nota de la asistencia: {0}", getNota());
    }
}

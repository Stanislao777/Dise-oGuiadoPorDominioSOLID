using System;

class Estudiante
{
    private string nombre;
    private int edad;
    private string sexo;
    private NotaGeneral notaGeneral;

    public Estudiante(string nombre, int edad, string sexo)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.sexo = sexo;
        notaGeneral = new NotaGeneral();
    }

    public void agregarEvaluacion(Evaluacion evaluacion)
    {
        notaGeneral.agregarEvaluacion(evaluacion);
    }

    public void mostrar()
    {
        Console.WriteLine("Nombre: {0}", nombre);
        Console.WriteLine("Edad: {0}", edad);
        Console.WriteLine("Sexo: {0}", sexo);
    }

    public void mostrarNotaGeneral()
    {
        Console.WriteLine("Nota total: {0}", notaGeneral.getNota());
        Console.WriteLine("- Evaluaciones: ");
        notaGeneral.mostrarEvaluaciones();
    }
}

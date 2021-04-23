using System;
using System.Collections.Generic;

class Curso
{
    private Encargado encargado;
    private IPagoTurno pagoTurno;
    private List<Estudiante> listaEstudiantes;

    public Curso(Encargado encargado, IPagoTurno pagoTurno)
    {
        this.encargado = encargado;
        this.pagoTurno = pagoTurno;
        this.listaEstudiantes = new List<Estudiante>();
    }

    public void agregarEstudiante(Estudiante estudiante)
    {
        listaEstudiantes.Add(estudiante);
    }

    public void mostrar()
    {
        Console.WriteLine("- Encargado:");
        encargado.mostrar();
        Console.WriteLine("Pago del turno: {0}", pagoTurno.getPago());
    }

    public void mostrarEstudiantes()
    {
        foreach(Estudiante estudiante in listaEstudiantes)
        {
            Console.WriteLine("=================================");
            estudiante.mostrar();
            estudiante.mostrarNotaGeneral();
            Console.WriteLine("=================================");
        }
    }
}

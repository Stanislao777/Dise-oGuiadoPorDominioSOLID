using System;
using System.Collections.Generic;

class NotaGeneral
{
    private List<Evaluacion> listaEvaluacion;

    public NotaGeneral()
    {
        listaEvaluacion = new List<Evaluacion>();
    }

    public void agregarEvaluacion(Evaluacion evaluacion)
    {
        listaEvaluacion.Add(evaluacion);
    }

    public double getNota()
    {
        double notaTotal = 0.0;
        foreach(Evaluacion evaluacion in listaEvaluacion)
        {
            notaTotal += evaluacion.getNota();
        }
        return notaTotal;
    }

    public void mostrarEvaluaciones()
    {
        foreach(Evaluacion evaluacion in listaEvaluacion)
        {
            Console.WriteLine("//////////////");
            evaluacion.mostrarDetalles();
            Console.WriteLine("//////////////");
        }
    }
}

using System;
using System.Collections.Generic;

class Evaluacion
{
	private List<BaseEvaluacion> estudiantes;

	public Evaluacion(List<BaseEvaluacion> pEstudiantes)
	{
		estudiantes = pEstudiantes;
	}

	public void calcularEvaluacion()
	{
		double total = 0;

		foreach (var estudiante in estudiantes)
		{
			estudiante.CalcularNota();
			Console.WriteLine(estudiante);
			total += estudiante.Estudiante.Nota;	
		}

		Console.WriteLine("\nEl total de las notas de las evaluadas son {0}", total);
	}
}
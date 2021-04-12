using System;
using System.Collections.Generic;

class Evaluacion
{
	private List<Estudiante> estudiantes;

	public Evaluacion(List<Estudiante> pEstudiantes)
	{
		estudiantes = pEstudiantes;
	}

	public void calcularEvaluacion()
	{
		double total = 0;

		foreach (Estudiante estudiante in estudiantes)
		{
			if (estudiante.Evaluacion == 1)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				estudiante.Nota *= 0.8;
				Console.WriteLine(estudiante);
				total += estudiante.Nota;
			}
			if (estudiante.Evaluacion == 2)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				estudiante.Nota *= 1.2;
				Console.WriteLine(estudiante);
				total += estudiante.Nota;
			}
		}

		Console.WriteLine("\nEl total de las notas de las evaluadas son {0}", total);
	}
}
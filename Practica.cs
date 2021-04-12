using System;
using System.Collections.Generic;

class Practica
{
	private List<Estudiante> estudiantes;

	public Practica(List<Estudiante> pEstudiantes)
	{
		estudiantes = pEstudiantes;
	}

	public void calcularPracticas()
	{
		double total = 0;

		foreach (Estudiante estudiante in estudiantes)
		{
			if (estudiante.Practica == 1)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				estudiante.Nota *= 0.8;
				Console.WriteLine(estudiante);
				total += estudiante.Nota;
			}
			if (estudiante.Practica == 2)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				estudiante.Nota *= 1.2;
				Console.WriteLine(estudiante);
				total += estudiante.Nota;
			}
		}

		Console.WriteLine("\nEl total de las notas de las practicas es {0}", total);
	}
}
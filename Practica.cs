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
			Console.WriteLine(estudiante);
			total += estudiante.Nota;
		}

		Console.WriteLine("\nEl total de las notas de las practicas es {0}", total);
	}
}
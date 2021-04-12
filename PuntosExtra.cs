using System;

class PuntosExtra
{
	public static double CalcularPuntosExtra(Estudiante pEstudiante)
	{
		return pEstudiante.Nota * 0.5;
	}

	public static void IncrementarPuntos(Estudiante pEstudiante	)
	{
		double puntExt = CalcularPuntosExtra(pEstudiante);
		Console.WriteLine("Se anadio {0} de nota a {1}", puntExt, pEstudiante.Nombre);
	}

}
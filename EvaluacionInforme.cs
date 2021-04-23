using System;

class EvaluacionInforme : BaseEvaluacion
{
	public EvaluacionInforme(Estudiante pEstudiante) : base (pEstudiante)
	{

	}

	public override double CalcularNota()
	{
		Console.ForegroundColor = ConsoleColor.Green;
		estudiante.Nota *= 0.8;
		return estudiante.Nota; 
	}
}
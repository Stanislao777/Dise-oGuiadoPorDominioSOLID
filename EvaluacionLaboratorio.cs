using System;

class EvaluacionLaboratorio : BaseEvaluacion
{
	public EvaluacionLaboratorio(Estudiante pEstudiante) : base (pEstudiante)
	{

	}

	public override double CalcularNota()
	{
		Console.ForegroundColor = ConsoleColor.Yellow;
		estudiante.Nota *= 1.2;
		return estudiante.Nota; 
	}
}
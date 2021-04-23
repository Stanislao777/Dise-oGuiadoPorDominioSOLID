using System;

abstract class BaseEvaluacion
{
	protected Estudiante estudiante;

	public Estudiante Estudiante {  get => estudiante; set => estudiante = value; }

	public BaseEvaluacion(Estudiante pEstudiante)
	{
		estudiante = pEstudiante;
	}

	public override string ToString()
	{
		return estudiante.ToString();
	}

	public abstract double CalcularNota();
}
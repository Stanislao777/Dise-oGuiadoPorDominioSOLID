using System;

class Estudiante
{
	private string nombre;
	private string paralelo;
	private int gestion;
	private int evaluacion;
	private double nota;

	public string Nombre {get => nombre; set => nombre = value; }
	public int Evaluacion {get => evaluacion; set => evaluacion = value; }
	public double Nota {get => nota; set => nota = value; }

	public Estudiante(string pNombre, string pParalelo, int pGestion, int pEvaluacion, double pNota)
	{
		nombre = pNombre;
		paralelo = pParalelo;
		gestion = pGestion;
		evaluacion = pEvaluacion;
		nota = pNota;
	}
	
	public override string ToString()
	{
		return String.Format("La evaluacion de {0} tiene nota de {1}", nombre, nota);
	}	
}

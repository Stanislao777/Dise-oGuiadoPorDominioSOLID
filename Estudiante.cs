using System;

class Estudiante
{
	private string nombre;
	private string paralelo;
	private int gestion;
	private int practica;
	private double nota;

	public string Nombre {get => nombre; set => nombre = value; }
	public int Practica {get => practica; set => practica = value; }
	public double Nota {get => nota; set => nota = value; }

	public Estudiante(string pNombre, string pParalelo, int pGestion, int pPractica, double pNota)
	{
		nombre = pNombre;
		paralelo = pParalelo;
		gestion = pGestion;
		practica = pPractica;
		nota = pNota;
	}
	
	public override string ToString()
	{
		return String.Format("La practica de {0} tiene nota de {1}", nombre, nota);
	}	
}

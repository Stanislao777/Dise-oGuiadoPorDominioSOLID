using System;

class Estudiante
{
	private string nombre;
	private string paralelo;
	private int gestion;
	private double nota;

	public string Nombre {get => nombre; set => nombre = value; }
	public double Nota {get => nota; set => nota = value; }

	public Estudiante(string pNombre, string pParalelo, int pGestion, double pNota)
	{
		nombre = pNombre;
		paralelo = pParalelo;
		gestion = pGestion;
		nota = pNota;
	}
	
	public override string ToString()
	{
		return string.Format("{0},{1},{2},{3}", nombre, paralelo, gestion, nota);
	}	
}

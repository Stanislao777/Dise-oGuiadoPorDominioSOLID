using System;

class Estudiante
{
	private string nombre;
	private string paralelo;
	private int gestion;
	private double nota;

	public Estudiante(string pNombre, string pParalelo, int pGestion, double pNota)
	{
		nombre = pNombre;
		paralelo = pParalelo;
		gestion = pGestion;
		nota = pNota;
	}

	//public string Nombre {get => nombre; set => nombre = value};
	//public string Parelelo {get => paralelo; set => paralelo = value};

	public override string ToString()
	{
		return string.Format("{0},{1},{2},{3}", nombre, paralelo, gestion, nota);
	}

	public double CalcularPuntosExtra()
	{
		return nota * 0.5;
	}

	public void AsignarNota()
	{
		double puntExt = CalcularPuntosExtra();
		Console.WriteLine("Se anadio {0} en nota por parte de {1}", puntExt, nombre);
	}
}

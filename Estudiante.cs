class Estudiante
{
	private string nombre;
	private string paralelo;
	private int edad;
	private double nota;

	public Estudiante(string pNombre, string pParalelo, int pEdad, double pNota)
	{
		nombre = pNombre;
		paralelo = pParalelo;
		edad = pEdad;
		nota = pNota;
	}

	public string Nombre {get => nombre; set => nombre = value};
	public string Parelelo {get => paralelo; set => paralelo = value}

	public override string ToString()
	{
		return string.Format("{0},{1},{2},{3}", nombre, paralelo, edad, nota);
	}

	public double CalcularPuntosExtra()
	{
		return paralelo * 0.5;
	}

	public void AsignarNota()
	{
		double puntExt = CalcularPuntosExtra();
		Console.WriteLine("Se anadio {0} en nota por parte de {1}", puntExt, nombre);
	}
}

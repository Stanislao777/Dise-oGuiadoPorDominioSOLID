using System;

class MainClass {
  public static void Main (string[] args) {
    Estudiante estudiante = new Estudiante("Pedro", "Arqui1", 2020, 10);

	Console.WriteLine(estudiante);
	estudiante.CalcularPuntosExtra();
  }
}
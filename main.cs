using System;
using System.Collections.Generic;

class MainClass {
  static void Main (string[] args) 
  {
    /*Estudiante estudiante = new Estudiante("Pedro", "Arqui1", 2021, 1, 10);

	Console.WriteLine(estudiante);
	Console.WriteLine(PuntosExtra.CalcularPuntosExtra(estudiante));
	PuntosExtra.IncrementarPuntos(estudiante);*/

	List<Estudiante> estudiantes = new List<Estudiante>
	{
		new Estudiante("Jose","Arqui1", 2021, 1, 10.5),
		new Estudiante("Jose","Arqui1", 2021, 2, 5.7),
		new Estudiante("Juan","Arqui1", 2021, 1, 7.5),
		new Estudiante("Juan","Arqui1", 2021 ,2, 8.2)	
	};

	Evaluacion miEvaluacion = new Evaluacion(estudiantes);

	miEvaluacion.calcularEvaluacion();	
  }
}
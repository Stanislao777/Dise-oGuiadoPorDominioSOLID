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
		new Estudiante("Pedro","Arqui1", 2021,1, 5.7),
		new Estudiante("Juan","Arqui1", 2021, 1, 7.5),
		new Estudiante("Maria","Arqui1", 2021 ,1, 8.2)	
	};

	Practica miPractica = new Practica(estudiantes);

	miPractica.calcularPracticas();	
  }
}
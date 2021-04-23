using System;
using System.Collections.Generic;

class MainClass {
  static void Main (string[] args) 
  {
	List<BaseEvaluacion> estudiantes = new List<BaseEvaluacion>
	{
		new EvaluacionInforme(new Estudiante("Jose","Arqui1", 2021, 1, 10.5)),
		new EvaluacionLaboratorio(new Estudiante("Jose","Arqui1", 2021, 2, 5.7)),
		new EvaluacionInforme(new Estudiante("Juan","Arqui1", 2021, 1, 7.5)),
		new EvaluacionLaboratorio(new Estudiante("Juan","Arqui1", 2021 ,2, 8.2))
	};

	Evaluacion miEvaluacion = new Evaluacion(estudiantes);

	miEvaluacion.calcularEvaluacion();	
  }
}
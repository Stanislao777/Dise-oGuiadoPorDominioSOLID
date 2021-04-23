using System;

class MainClass
{
    public static void Main (string[] args)
    {
        Titulo titulo1 = new Titulo("C++ Cheatsheet", new Magistrado());
        Titulo titulo2 = new Titulo("Java Cheatsheet", new Doctorado());
        Titulo titulo3 = new Titulo("C# Cheatsheet", new Licenciatura());

        Encargado encargado = new Encargado("Estanis", 24, "M");
        encargado.agregarTitulo(titulo1);
        encargado.agregarTitulo(titulo2);
        encargado.agregarTitulo(titulo3);

        Curso curso = new Curso(encargado, new Tarde());
        curso.mostrar();

        Estudiante estudiante1 = new Estudiante("Samuel", 20, "M");
        Estudiante estudiante2 = new Estudiante("Estanis", 20, "M");
        Estudiante estudiante3 = new Estudiante("Jorge", 20, "M");
        Estudiante estudiante4 = new Estudiante("Oliver", 20, "M");

        curso.agregarEstudiante(estudiante1);
        curso.agregarEstudiante(estudiante2);
        curso.agregarEstudiante(estudiante3);
        curso.agregarEstudiante(estudiante4);

        estudiante1.agregarEvaluacion(new Tareas(10, "Tarea de progra 2", new DateTime(2020, 1, 1)));
        estudiante1.agregarEvaluacion(new Participacion(5, "Participo en clases y en laboratorio"));
        estudiante1.agregarEvaluacion(new Examen(10, "Primer examen", 10, new DateTime(2021, 2, 2)));

        estudiante2.agregarEvaluacion(new Asistencia(8, 7, 10));
        estudiante2.agregarEvaluacion(new Participacion(7, "Participo en clases"));
        estudiante2.agregarEvaluacion(new Examen(8, "Segundo examen", 10, new DateTime(2021, 3, 3)));
        
        estudiante3.agregarEvaluacion(new Tareas(9, "Tarea de diagrama de clases", new DateTime(2021, 3, 2)));
        estudiante3.agregarEvaluacion(new Participacion(10, "Participo en clases y en laboratorio"));
        estudiante3.agregarEvaluacion(new Examen(9, "Tercer examen", 10, new DateTime(2021, 5, 5)));
        
        estudiante4.agregarEvaluacion(new Asistencia(3, 4, 10));
        estudiante4.agregarEvaluacion(new Tareas(5, "Tarea de herencia", new DateTime(2021, 5, 4)));
        estudiante4.agregarEvaluacion(new Examen(6, "Tercer examen", 10, new DateTime(2021, 6, 4)));

        curso.mostrarEstudiantes();
    }
}

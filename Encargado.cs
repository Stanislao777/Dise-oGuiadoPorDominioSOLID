using System;
using System.Collections.Generic;

class Encargado
{
    private string nombre;
    private int edad;
    private string sexo;
    List<Titulo> listaTitulos;

    public Encargado(string nombre, int edad, string sexo)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.sexo = sexo;
        listaTitulos = new List<Titulo>();
    }

    public void mostrar()
    {
        Console.WriteLine("Nombre: {0}", nombre);
        Console.WriteLine("Edad: {0}", edad);
        Console.WriteLine("Sexo: {0}", sexo);
    }

    public void agregarTitulo(Titulo titulo)
    {
        listaTitulos.Add(titulo);
    }

    public void mostrarTitulos()
    {
        foreach(Titulo titulo in listaTitulos)
        {
            Console.WriteLine("=================================");
            titulo.mostrar();
            Console.WriteLine("=================================");
        }
    }

}

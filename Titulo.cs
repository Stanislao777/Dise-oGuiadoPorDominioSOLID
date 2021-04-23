using System;

class Titulo
{
    private string nombre;
    public string Nombre { get => nombre; set => nombre = value; }

    private IServicioCalculoPesoLaboral servicioCalculoPesoLaboral;

    public Titulo(string nombre, IServicioCalculoPesoLaboral servicioCalculoPesoLaboral)
    {
        this.nombre = nombre;
        this.servicioCalculoPesoLaboral = servicioCalculoPesoLaboral;
    }

    public void mostrar()
    {
        Console.WriteLine("Nombre: {0}", nombre);
        Console.WriteLine("Peso laboral: {0}", servicioCalculoPesoLaboral.getPeso());
    }
}

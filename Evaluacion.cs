abstract class Evaluacion
{
    protected double nota;

    public Evaluacion(double nota)
    {
        this.nota = nota;
    }

    public double getNota()
    {
        return nota;
    }

    public abstract void mostrarDetalles();
}

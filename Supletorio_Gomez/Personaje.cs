public class Personaje : IPersonaje
{
    private string nombre;

    public Personaje(string nombre)
    {
        this.nombre = nombre;
    }

    public string ObtenerNombre()
    {
        return nombre;
    }
}
public abstract class Fusion : IPersonaje
{
    protected IPersonaje personaje1;
    protected IPersonaje personaje2;

    public Fusion(IPersonaje personaje1, IPersonaje personaje2)
    {
        this.personaje1 = personaje1;
        this.personaje2 = personaje2;
    }

    public abstract string ObtenerNombre();
}
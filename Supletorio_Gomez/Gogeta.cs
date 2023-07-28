public class Gogeta : Fusion
{
    public Gogeta(IPersonaje personaje1, IPersonaje personaje2) : base(personaje1, personaje2) { }

    public override string ObtenerNombre()
    {
        return personaje1.ObtenerNombre() + "-" + personaje2.ObtenerNombre() + " (Gogeta)";
    }
}
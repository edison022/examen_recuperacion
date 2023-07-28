public class Program
{
    public static void Main()
    {
        IPersonaje goku = new Goku();
        IPersonaje vegeta = new Vegeta();
        IPersonaje goten = new Goten();
        IPersonaje trunks = new Trunks();

        IPersonaje gogeta = new Gogeta(goku, vegeta);
        IPersonaje gotenks = new Gotenks(goten, trunks);

        
        Console.WriteLine(gogeta.ObtenerNombre()); 
        Console.WriteLine(gotenks.ObtenerNombre()); 
    }
}
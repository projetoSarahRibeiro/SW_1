namespace animal;
class Program
{
    static void Main(string[] args)
    {
        
        Cao c = new Cao();
        Gato g = new Gato();
        Humano h = new Humano();

        Console.WriteLine("O homem" + h.Fala() + "O gato" + g.Fala() + " O cão" + c.Fala());

    }
}

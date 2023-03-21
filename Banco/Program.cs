namespace banco;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Banco Etec MCM");
        Conta c = new Conta();
        //c.Saldo = 1500;
        c.Depositar(1500);
        //c.Limite = 500;
        c.AjusteLimite(500);
        c.Sacar(200);

        //Console.WriteLine("Seu saldo é de:" + c.Saldo + "e seu 
        //limite é de:" + c.Limite);
        Console.WriteLine("Seu saldo é de:" + c.MostrarSaldo()); 
    }
}

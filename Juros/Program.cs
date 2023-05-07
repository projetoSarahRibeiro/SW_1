namespace atividadeJuros;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Banco banco = new Banco();

        banco.cliente ="Dazai";
        Console.Write(banco.cliente + " Digite o quanto você quer de emprestimo!");
        string? textovalor = Console.ReadLine();
        double valor = Convert.ToDouble(textovalor);
        banco.valor = valor;

        Console.WriteLine("Seu valor do emprestimo! "+ banco.valor);
        Console.WriteLine("Seus juros: "+ banco.juros());
        Console.WriteLine("Juros do mês: "+ banco.mensal());

        banco.saldo = 2000;
        
       /* 
       double saldo = banco.consultaSaldo;
        banco.limite = 300;
        banco.deposito(30);
        banco.deposito(30);
        banco.limite = 300;
        Console.WriteLine(banco.consultaSaldo());
        double saldo = banco.consultaSaldo;
        
        /*
        double saldo = banco.consultaSaldo;
        banco.limite = 1500;
        banco.saque();
        banco.deposito();*/

    }
}

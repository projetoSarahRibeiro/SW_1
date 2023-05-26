namespace exercicio03;
class Program
{
    static void Main(string[] args)
    {
        

        Contrato c = new Contrato();
        ContratoPessoaFisica cf = new ContratoPessoaFisica();
        ContratoPessoaJuridica cj = new ContratoPessoaJuridica();

        cf.Nome = "Sora";
        cf.Email = "kuhakuu@gmail.com";
        cf.Telefone = "942540373";
        cf.Idade = 18;
        cf.Cpf = 49489670847;
        cj.Nome = "No game No Life";
        cj.Email = "gamepff@gmail.com";
        cj.Telefone = "333388888";
        cj.Cnpj = 8556679766789;
        cj.Inscricao = 0376897;
        cj.Prazo = 26;
        cf.Prazo = 26;

        Console.WriteLine(cf.MostraDados());
         Console.WriteLine(cf.CalcularPrestacao());
        Console.WriteLine(cj.MostraDados());
         Console.WriteLine(cj.CalcularPrestacao());
       
        
    }
} 


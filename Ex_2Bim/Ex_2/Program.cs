namespace exe02;
class Program
{
    static void Main(string[] args)
    {
        Contrato c = new Contrato();
        ContratoPF cf = new ContratoPF();
        ContratoPJ cj = new ContratoPJ();

        cf.Tipo = "Pessoa Física";
        cf.Idade = 50;
        cf.Cpf = 12345678910;

        cj.Tipo = "Pessoa Jurídica";
        cj.Cnpj = 19876543210;
        cj.Inscricao = 13579246810;

        //Contrato Pessoa Juridica
        Console.WriteLine("O seu tipo de contrato: " + cj.Tipo);
        Console.WriteLine("Inscrição estadual: " +cj.Inscricao);
         Console.WriteLine("Seu Cnpj: " + cj.Cnpj);

        //Contrato Pessoa Fisíca
        Console.WriteLine("O seu tipo de  contrato: " + cf.Tipo);
        Console.WriteLine("A idade da Pessoa Física: " + cf.Idade + "anos");
        Console.WriteLine("Seu Cpf: " + cf.Cpf);
    }
} 
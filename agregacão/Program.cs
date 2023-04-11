namespace agregacão;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Trabalho de agregação!!");

        //Instaciando os objetos de cada classe
        Cartao cdc = new Cartao();
        Cliente cli = new Cliente();

        //Adicionando um nome para um cliente
        cli.Nome = "Sarah";

        //Adicionando número e validade do cartão
        cdc.Numero = "987654321";
        cdc.DataValida = "04/2030";

        //Associando o cliente ao atributo da agregacão em Cartão
        cdc.Cliente = cli;

        //Vizualizando as infromações
        Console.WriteLine("O nome dpo cliente é:" + cli.Nome);
        Console.WriteLine("O número do cartão é:" + cdc.Numero);
        Console.WriteLine("A data de validade do cartão é:" + cdc.DataValida);
        Console.WriteLine("O nome do cliente AGREGADO é:" + cdc.Cliente.Nome);
    }
}

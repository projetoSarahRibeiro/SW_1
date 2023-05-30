namespace Ex_02;
class Program
{
    static void Main(string[] args)
    {
        //Instância de cada classe filha
        Estadual prodEstadual = new Estadual();
        Nacional prodNacional = new Nacional();
        Importado prodImportado = new Importado();

        //Instanciando valores para atributos comuns
        Console.WriteLine("Digite a descrição do Prod Estadual");
        prodEstadual.Descricao = Console.ReadLine();
         Console.WriteLine("Digite o valor Produto Estadual");
         prodEstadual.Valor = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Digite o valor do imposto do Produto Estadual");
         prodEstadual.Imposto = Convert.ToDouble(Console.ReadLine());

         Console.WriteLine("Valor do produto calculado com imposto:");
         Console.WriteLine(prodEstadual.calculaValor());


         Console.WriteLine("Digite a descrição do Prod Nacional");
         prodNacional.Descricao = Console.ReadLine();
         Console.WriteLine("Digite o valor Produto Nacional");
         prodNacional.Valor = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Digite o valor do imposto do Produto Nacional");
         prodNacional.Imposto = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Digite o valor da taxa do Produto Nacional");
         prodNacional.Taxa = Convert.ToDouble(Console.ReadLine());

         Console.WriteLine("Valor do produto calculado com imposto:");
         Console.WriteLine(prodNacional.calculaValor());


         Console.WriteLine("Digite a descrição do Prod Importação");
         prodImportado.Descricao = Console.ReadLine();
         Console.WriteLine("Digite o valor Produto Nacional");
         prodImportado.Valor = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Digite o valor do imposto do Produto Nacional");
         prodImportado.Imposto = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Digite o valor da taxa de importação do Produto Nacional");
         prodImportado.Taxaimport = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Digite o valor da taxa do Produto Nacional");
        

         Console.WriteLine("Valor do produto calculado com imposto:");
         Console.WriteLine(prodImportado.calculaValor());




    }
}

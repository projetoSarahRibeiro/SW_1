namespace projeto_loja;
class Produtos
{
    public Produtos(){
        this.Nome = "TicToc";
        this.Preco = 15;
    }
    public Produtos(string nome){
        this.Nome = nome;
        this.Preco = 10;
    }
    public Produtos(string nome, int desconto){
        this.Nome = nome;
        this.Preco = 10 - (10*desconto/100);
    }




    private string? Nome{get;set;}
    private double Preco {get;set;}
    public void AlteraNome(string nome){
        this.Nome = nome;
    }
    public void AlteraPreco(double preco){
        this.Preco = preco;
    }
    public void MostraDado(){
        Console.WriteLine("Nome:" + this.Nome);
        Console.WriteLine("Preço:" + this.Preco);
    }
}

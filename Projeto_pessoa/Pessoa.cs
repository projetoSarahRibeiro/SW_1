namespace projeto_pessoa;
class Pessoa
{
    public Pessoa(){
        this.Nome = "NÃO INFORMADO";
        this.SobereNome ="NÃO INFORMADO";
        this.Idade = 0;
    }
    public Pessoa( string nome, int idade){
        this.Nome = nome;
        this.SobereNome ="NÃO INFORMADO";
        this.Idade = idade;
    }
    

  private string? Nome {get;set;}
  private string? SobereNome {get;set;}
  private int Idade {get;set;}

  public void AlterarNome(string nome){
     this.Nome = nome;
  }
  public void AlteraSobreNome(string soberenome){
     this.Nome = soberenome;
  }
  public void AlterarIdade(int idade){
        int idade1 = idade;
  }
  public void MostraDados(){
    Console.WriteLine("Nome:" + this.Nome);
    Console.WriteLine("SobreNome:" + this.SobereNome);
    Console.WriteLine("Idade:" + this.Idade);
  }
   
}

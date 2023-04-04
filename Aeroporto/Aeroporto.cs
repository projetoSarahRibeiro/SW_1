namespace Aeroporto;
class Aeroporto
{   
    public Aeroporto(double codigo, string empresa){
         this.Codigo = codigo;
        this.Empresa = empresa;
        this.CidadeEntra = "Não LIDO";
        this.CidadeSai = "Não LIDO";
        
    }
    public Aeroporto(double codigo, string empresa, string cidadeentra, string cidadesai){
        this.Codigo = codigo;
        this.Empresa = empresa;
        this.CidadeEntra = cidadeentra;
        this.CidadeSai = cidadesai ;
    }


    private double Codigo{get;set;}
    private string? Empresa{get;set;}
    public string? CidadeEntra{get;set;}
    public string? CidadeSai{get;set;}

    public void FazCodigo(double codigo){
          this.Codigo = codigo;
    }
    public void FazEmpresa(string empresa){
          this.Empresa = empresa;
    }
    public void Entra(string cidadeentra){
          this.CidadeEntra = cidadeentra;
    }
    public void Sai(string cidadesai){
          this.CidadeSai = cidadesai;
    }
    public void MostraDados(){
        Console.WriteLine("Código: " + this.Codigo);
        Console.WriteLine("Companhia: " + this.Empresa);
        Console.WriteLine("Cidade destino: " + this.CidadeEntra);
        Console.WriteLine("Cidade de saída: " + this.CidadeSai);
    }





}

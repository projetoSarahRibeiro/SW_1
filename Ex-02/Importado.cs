namespace Ex_02;
class Importado:Produto
{
    public double Taxa {get;set;}
    public double Taxaimport {get;set;}

    public override double calculaValor()
    {
        double tx = this.Valor*(1+(this.Taxa/100));
        double tximp =this.Valor*(1+(this.Taxaimport/100));
        return base.calculaValor()+tx+tximp; 
    }

}

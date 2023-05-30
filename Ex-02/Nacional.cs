namespace Ex_02;
class Nacional:Produto
{
    public double Taxa {get;set;}

    public override double calculaValor()
    {
        double tx = this.Valor*(1+(this.Taxa/100));
        return base.calculaValor()+tx;
    }
}

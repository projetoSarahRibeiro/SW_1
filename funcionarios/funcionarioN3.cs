namespace funcionarios;
class funcionarioN3: funcionarioM
{
   public  string? Cargo {get;set;}
    public override double Lucro(){
        return base.Lucro()*0.03;
    }

}

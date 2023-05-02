namespace funcionarios;
class funcionarioN1: funcionarioM
{
  

    public override double Lucro(){
        return base.Lucro()*0.01;
    }

}

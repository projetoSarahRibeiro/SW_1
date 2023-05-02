namespace funcionarios;
class funcionarioN2: funcionarioM
{
   

    public override double Lucro(){
        return base.Lucro()*0.02;
    }

}

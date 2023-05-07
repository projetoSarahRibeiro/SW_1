namespace atividadeJuros;
class BancoBB
{
   public string? cliente {get; set;}
   public double limite {get;set;}
   public double saldo {get;set;}
   
   public double valor;
   
   public void deposito (double valor){
      this.saldo += valor;
   }
   public void saque (double valor){
      this.saldo -= valor;
   }
   public double consultaSaldo (){
      return this.saldo += this.limite;
   }
   public double juros(){
      double Juros = ((valor * 0.06)*12) + valor;
      return Juros;
   }
   public double mes (){
      double Mes = ((valor * 0.06)+ valor/12);
      return Mes;
   }
    
}

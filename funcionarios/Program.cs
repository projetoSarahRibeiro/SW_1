namespace funcionarios;
class Program
{
    static void Main(string[] args)
    {
        funcionarioN1 n1 = new funcionarioN1();
        funcionarioN2 n2 = new funcionarioN2();
        funcionarioN3 n3 = new funcionarioN3();

        n1.Nome = "Kaneki ken";
        n1.Idade = 24;
        n2.Nome = "Sora";
        n2.Idade = 18;
        n3.Nome = "Ciel";
        n3.Idade = 13;
        n3.Cargo = "Gerente";
       

        Console.WriteLine("Nome: " + n1.Nome +"-- Idade: " + n1.Idade + "-- Lucro: " + n1.Lucro());
        Console.WriteLine("Nome: " + n2.Nome +"-- Idade: " + n2.Idade + "-- Lucro: " + n2.Lucro());
        Console.WriteLine("Nome: " + n3.Nome +"-- Idade: " + n3.Idade + "-- Lucro: " + n3.Lucro() + "-- Cargo: " + n3.Cargo);

    }
}

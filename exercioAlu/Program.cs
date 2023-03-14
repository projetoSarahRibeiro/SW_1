namespace ExercioAluno;
class Program
{
    static void Main(string[] args)
    {
        Alunos aluno1 = new Alunos();
        
        Console.WriteLine("Digite seu nome:");
        aluno1.nome = Console.ReadLine();

        Console.WriteLine("Digite a primeria nota:");
        aluno1.nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota:");
        aluno1.nota2 = Convert.ToDouble(Console.ReadLine());
        
        

        aluno1.mensagem();
    }
}
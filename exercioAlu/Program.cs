﻿namespace ExercioAluno;
class Program
{
    static void Main(string[] args)
    {
        Alunos aluno1 = new Alunos();
        aluno1.nome = "Fulano da Silva";
        aluno1.nota1 = 4.3;
        aluno1.nota2 = 7.8;

        aluno1.mensagem();
    }
}
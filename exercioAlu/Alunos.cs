namespace ExercioAluno;
class Alunos
{
    public string nome="";
    public double nota1, nota2;


//MEDIA -> retorna em double(por exemplo com 8.3)
//SITUAÇÃO -> retorna vomo striimg("Aprovado" ou "Reprovado")
//MENSAGEM -> não retorna nada, só mostra na tela os detalhes(nome, media,etc)




public double obterMedia(){
    double media = (nota1+nota2)/2;
    return media; 
}

public string obterSituacao(double media){
    string situacao="";
    if(media>=6){
        
        situacao="Aprovado";

    }else{
        situacao="Reprovado";
    }
    return situacao;    

}

public void mensagem(){
    double mediaCalculada = obterMedia();
    string resultadoSituacao = obterSituacao(mediaCalculada);
    Console.WriteLine(nome+"está"+resultadoSituacao+"com media"+mediaCalculada);
}

}


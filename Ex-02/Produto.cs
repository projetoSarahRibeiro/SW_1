﻿namespace Ex_02;
class Produto
{
    public string? Descricao {get;set;}
    public double Valor { get;set;}
    public double Imposto {get;set;}

    public virtual double calculaValor(){
        double imp = (1+(this.Imposto/100));

        return this.Valor*imp;
    }
}

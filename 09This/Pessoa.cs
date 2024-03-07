using System;

class Pessoa
{

    // Atributo 
    private string nome = "Roberto";

    //Construtor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }

}
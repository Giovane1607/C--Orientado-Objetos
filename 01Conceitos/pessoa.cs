//using System;

class Pessoa
{

    // Atributos
    public string nome = "";
    public int idade;

    public int RA;

    public string? sexo; 

    //Métodos

    public void mensagem()
    {
        Console.WriteLine(" Olá "+nome+" Seja bem vindo a faculdade FHO! Sua idade é de "+idade+" anos" + " Seu RA é: "+RA+" Seu Sexo é: "+sexo);
    }


}
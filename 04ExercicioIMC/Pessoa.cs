using System;

class Pessoa
{
    public string nome = "";
    public double peso, altura;



    public double calculo()
    {
        return (peso / (altura * altura));
    }

    public string situacao(double imc)
    {
        // Variavel de retorno
        string retorno;

        if (imc < 18.5)
        {
            retorno = "Abaixo do peso";
        }
        else if (imc < 25)
        {
            retorno = "Peso normal";
        }
        else if (imc < 30)
        {
            retorno = "Acima do Peso";
        }
        else if (imc < 35)
        {
            retorno = "Obesidade I";
        }
        else if (imc < 40)
        {
            retorno = "Obesidade II";
        }
        else
        {
            retorno = "Obesidade III";
        }

        return retorno;
    }

    //Mensagem

    public void Mensagem()
    {
        //Obter o cálculo
        double obterCalculo = calculo();

        //Obter Situação
        string obterSituacao = situacao(obterCalculo);
        string obterNome = nome;

        //Exibir Mensagem
        Console.WriteLine($"Nome: {obterNome}");
        Console.WriteLine($"Seu IMC é de: {Math.Round(obterCalculo, 2)}");
        Console.WriteLine($"Sua Situação é de: {obterSituacao}");

    }
}
using System;

class PessoaFisica : Padrao
{

    //Método Obrigatório
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de empréstimo para pessoa Física R$: "+(valor * 0.1));
    }


}
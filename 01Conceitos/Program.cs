namespace Orientação_a_Objetos;

class Program
{
    static void Main(string[] args)
    {
        // Instanciar um objeto
        Pessoa aluno = new Pessoa();
        aluno.nome = "Giovane";
        aluno.idade = 20;
        aluno.RA = 113428;
        aluno.sexo = "Masculino";
        aluno.mensagem();
    }
}

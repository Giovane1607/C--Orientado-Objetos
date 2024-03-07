namespace ExercicioEscolar03;

class Program
{
    static void Main(string[] args)
    {
        // Instanciar objeto da classe Aluno
        Aluno a = new Aluno();
        a.nome = "Roberto";
        a.nota1 = 3;
        a.nota2 = 5;
        a.mensagem();
    }
}

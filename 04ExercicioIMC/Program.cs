namespace ExercicioIMC04;

class Program
{
    static void Main(string[] args)
    {
        //Instanciar um objeto

        Pessoa p = new Pessoa();
        p.nome = "Roberto";
        p.peso = 75;
        p.altura = 1.70;
        p.Mensagem();
    }
}

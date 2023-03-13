internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa p = new Pessoa();
        Console.WriteLine("informe seu nome");
        p.DefinirNome(Console.ReadLine());
        Console.WriteLine("informe sobrenome");
        p.DefinirSobrenome(Console.ReadLine());
        Console.WriteLine("Nome: " + p.RetornarNome());
        Console.WriteLine("Sobrenome: " + p.RetornarSobrenome());
        Console.WriteLine("Nome completo: " + p.RetornarNomeCompleto());
    }

    public class Pessoa
    {
        string? nome;
        string? sobrenome;

        public Pessoa()
        {

        }

        public void DefinirNome(string nome)
        {
            this.nome = nome;
        }

        public string RetornarNome()
        {
            return this.nome;
        }

        public void DefinirSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        public string RetornarSobrenome()
        {
            return this.sobrenome;
        }

        public string RetornarNomeCompleto()
        {

            return this.nome + " " + this.sobrenome;
        }
    }
}


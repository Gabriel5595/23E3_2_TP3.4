using System;

interface IPublicacao
{
    string Tipo { get; }
    string Nome{ get; }

    DateTime devolucao();
}

class Livro : IPublicacao
{
    public string Tipo => "Livro";
    public string Nome {get;}

    public Livro(string nome)
    {
        Nome = nome;
    }

    public DateTime devolucao()
    {
        return DateTime.Today.AddDays(5);
    }
}

class Jornal : IPublicacao
{
    public string Tipo => "Jornal";
    public string Nome {get;}

    public Jornal(string nome)
    {
        Nome = nome;
    }

    public DateTime devolucao()
    {
        return DateTime.Today.AddDays(7);
    }
}

class Revista : IPublicacao
{
    public string Tipo => "Revista";
    public string Nome {get;}

    public Revista(string nome)
    {
        Nome = nome;
    }

    public DateTime devolucao()
    {
        return DateTime.Today.AddDays(15);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Livro livro = new Livro("Guia do Mochileiro das Galáxias");
        Jornal jornal = new Jornal("O Globo");
        Revista revista = new Revista("Heavy Metal");

        Console.WriteLine($"Tipo: {livro.Tipo}, Nome: {livro.Nome}, Data de Devolução: {livro.devolucao():dd/MM/yyy}");
        Console.WriteLine($"Tipo: {jornal.Tipo}, Nome: {jornal.Nome}, Data de Devolução: {jornal.devolucao():dd/MM/yyy}");
        Console.WriteLine($"Tipo: {revista.Tipo}, Nome: {revista.Nome}, Data de Devolução: {revista.devolucao():dd/MM/yyy}");
    }
}
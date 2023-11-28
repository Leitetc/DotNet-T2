using System;
using System.Collections.Generic;

class Pessoa
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string CPF { get; set; }

    public Pessoa(string nome, DateTime dataNascimento, string cpf)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        CPF = cpf;
    }
}

class Instrutor : Pessoa
{
    public string CREF { get; set; }

    public Instrutor(string nome, DateTime dataNascimento, string cpf, string cref) 
        : base(nome, dataNascimento, cpf)
    {
        CREF = cref;
    }
}

class Cliente : Pessoa
{
    public double Altura { get; set; }
    public double Peso { get; set; }

    public Cliente(string nome, DateTime dataNascimento, string cpf, double altura, double peso) 
        : base(nome, dataNascimento, cpf)
    {
        Altura = altura;
        Peso = peso;
    }
}

class Academia
{
    public List<Instrutor> Instrutores { get; set; }
    public List<Cliente> Clientes { get; set; }

    public Academia()
    {
        Instrutores = new List<Instrutor>();
        Clientes = new List<Cliente>();
    }

    public void AdicionarInstrutor(Instrutor instrutor)
    {
        Instrutores.Add(instrutor);
    }

    public void AdicionarCliente(Cliente cliente)
    {
        Clientes.Add(cliente);
    }

    public void MostrarListaInstrutores()
    {
        Console.WriteLine("Lista de Instrutores:");
        foreach (var instrutor in Instrutores)
        {
            Console.WriteLine($"Nome: {instrutor.Nome}, CPF: {instrutor.CPF}, CREF: {instrutor.CREF}");
        }
    }

    public void MostrarListaClientes()
    {
        Console.WriteLine("Lista de Clientes:");
        foreach (var cliente in Clientes)
        {
            Console.WriteLine($"Nome: {cliente.Nome}, CPF: {cliente.CPF}, Altura: {cliente.Altura}, Peso: {cliente.Peso}");
        }
    }
}

class Program
{
    static void Main()
    {
        Academia academia = new Academia();

        Instrutor instrutor1 = new Instrutor("João", new DateTime(1980, 5, 15), "12345678901", "ABC123");
        Instrutor instrutor2 = new Instrutor("Maria", new DateTime(1990, 8, 25), "98765432109", "XYZ456");

        Cliente cliente1 = new Cliente("Carlos", new DateTime(1995, 3, 10), "11122233344", 1.75, 70.5);
        Cliente cliente2 = new Cliente("Ana", new DateTime(1988, 11, 20), "55566677788", 1.65, 60.0);

        academia.AdicionarInstrutor(instrutor1);
        academia.AdicionarInstrutor(instrutor2);

        academia.AdicionarCliente(cliente1);
        academia.AdicionarCliente(cliente2);

        academia.MostrarListaInstrutores();
        academia.MostrarListaClientes();
    }
}
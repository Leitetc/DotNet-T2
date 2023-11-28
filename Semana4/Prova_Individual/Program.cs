// See https://aka.ms/new-console-template for more information
Console.WriteLine("Prova individual 28/11/2023");

using System;
using System.Collections.Generic;
using System.Linq;

// Classe principal do programa
class Program
{
    static void Main()
    {
        // Exemplo de uso das classes e relatórios
        Academia academia = new Academia();

        // Adicionando treinadores e clientes
        academia.AdicionarTreinador(new Treinador("João", new DateTime(1980, 5, 10), "12345678901", "CREF123"));
        academia.AdicionarTreinador(new Treinador("Maria", new DateTime(1990, 3, 15), "98765432101", "CREF456"));

        academia.AdicionarCliente(new Cliente("Carlos", new DateTime(1995, 8, 20), "11122233344", 1.75, 70));
        academia.AdicionarCliente(new Cliente("Ana", new DateTime(2000, 2, 5), "55566677788", 1.60, 55));

        // Gerando relatórios
        List<Treinador> treinadoresPorIdade = academia.RelatorioTreinadoresPorIdade(30, 50);
        List<Cliente> clientesPorIdade = academia.RelatorioClientesPorIdade(18, 35);
        List<Cliente> clientesPorIMC = academia.RelatorioClientesPorIMC(22);
        List<Cliente> clientesOrdemAlfabetica = academia.RelatorioClientesOrdemAlfabetica();
        List<Cliente> clientesMaisVelhosParaMaisNovos = academia.RelatorioClientesMaisVelhosParaMaisNovos();
        List<Pessoa> aniversariantesDoMes = academia.RelatorioAniversariantesDoMes(5);

        // Exibindo resultados (pode ser adaptado conforme a interface gráfica desejada)
        Console.WriteLine("Treinadores por idade entre 30 e 50 anos:");
        foreach (var treinador in treinadoresPorIdade)
        {
            Console.WriteLine(treinador.Nome);
        }

        // Repita o processo para os outros relatórios...

        // Aguarde a entrada do usuário antes de fechar a aplicação
        Console.ReadLine();
    }
}

// Classe para representar a academia
class Academia
{
    private List<Treinador> treinadores = new List<Treinador>();
    private List<Cliente> clientes = new List<Cliente>();

    public void AdicionarTreinador(Treinador treinador)
    {
        // Verifica se o CPF e CREF são únicos
        if (treinadores.Any(t => t.CPF == treinador.CPF) || treinadores.Any(t => t.CREF == treinador.CREF))
        {
            Console.WriteLine("Erro: CPF ou CREF já cadastrado.");
        }
        else
        {
            treinadores.Add(treinador);
        }
    }

    public void AdicionarCliente(Cliente cliente)
    {
        // Verifica se o CPF é único
        if (clientes.Any(c => c.CPF == cliente.CPF))
        {
            Console.WriteLine("Erro: CPF já cadastrado.");
        }
        else
        {
            clientes.Add(cliente);
        }
    }

    // Implementação dos relatórios
    public List<Treinador> RelatorioTreinadoresPorIdade(int idadeMinima, int idadeMaxima)
    {
        // Implementar lógica para retornar treinadores dentro da faixa etária especificada
        // ...
    }

    public List<Cliente> RelatorioClientesPorIdade(int idadeMinima, int idadeMaxima)
    {
        // Implementar lógica para retornar clientes dentro da faixa etária especificada
        // ...
    }

    public List<Cliente> RelatorioClientesPorIMC(double valorIMC)
    {
        // Implementar lógica para retornar clientes com IMC maior que o valor especificado
        // ...
    }

    public List<Cliente> RelatorioClientesOrdemAlfabetica()
    {
        // Implementar lógica para retornar clientes em ordem alfabética
        // ...
    }

    public List<Cliente> RelatorioClientesMaisVelhosParaMaisNovos()
    {
        // Implementar lógica para retornar clientes do mais velho para o mais novo
        // ...
    }

    public List<Pessoa> RelatorioAniversariantesDoMes(int mes)
    {
        // Implementar lógica para retornar treinadores e clientes aniversariantes do mês especificado
        // ...
    }
}

// Classe base para pessoa
class Pessoa
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }

    public int CalcularIdade()
    {
        // Implementar lógica para calcular a idade
        // ...
    }
}

// Classe para representar treinadores
class Treinador : Pessoa
{
    public string CPF { get; set; }
    public string CREF { get; set; }
}

// Classe para representar clientes
class Cliente : Pessoa
{
    public string CPF { get; set; }
    public double Altura { get; set; }
    public double Peso { get; set; }

    public double CalcularIMC()
    {
        // Implementar lógica para calcular o IMC
        // ...
    }
}
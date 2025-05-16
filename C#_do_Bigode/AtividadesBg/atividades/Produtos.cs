using System;
using System.Collections.Generic;
using AtividadeAvalitiva.Models;

namespace AtividadeAvalitiva
{
    public static class Produtos
    {
        public static void Executar()
        {
            List<Produto> produtos = new List<Produto>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                produtos.Add(new Produto { Nome = nome, Preco = preco, Quantidade = quantidade });
            }

            foreach (var p in produtos)
                Console.WriteLine($"{p.Nome} - Total em estoque: {p.Preco * p.Quantidade}");
        }
    }
}

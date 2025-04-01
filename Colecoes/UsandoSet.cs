﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class UsandoSet
    {
        public class Produto
        {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }
        }

        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("Camisa do Corinthians", 299.9),
                new Produto("Camisa do Palmeiras", 299.9)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);

            foreach (var item in carrinho)
            {
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
        }
    }
}

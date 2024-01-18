using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);



            /*
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            
            int idade = 32;
            double saldo = 10.21424;
            string nome = "Gabriel";
            Console.WriteLine(saldo.ToString("F2")); // DELIMITAR O NÚMERO DE CASAS
            Console.WriteLine(saldo.ToString("F4")); // Delimitar 4 casas decimais
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // Delimitar 4 casas decimais
            Console.WriteLine("{0} tem {1} ano(s) e tem saldo igual a {2:F2} reais.", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} ano(s) e tem saldo igual a {saldo:F2} reais.");

            double a;
            float b;

            a = 5.1;
            b = (float) a;

            double n1 = 1.0, n2 = -3.0, n3 = -4.0;

            double delta = Math.Pow(2, 2) - 4.0 * n1 * n3;
            double x1 = (-n2 + Math.Sqrt(delta)) / (2.0 * n1);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            */
        }
    }
}
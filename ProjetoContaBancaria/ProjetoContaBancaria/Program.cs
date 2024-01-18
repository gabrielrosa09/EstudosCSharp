using ProjetoContaBancaria;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c1;
            Console.WriteLine("Entre o número da conta: ");
            int num_conta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o titular da conta:  ");
            string nome = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)?");
            char dep = char.Parse(Console.ReadLine());
            if (dep == 's' || dep == 'S')
            {
                Console.WriteLine("Entre com o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine());

                c1 = new ContaBancaria(nome, num_conta, saldo);
                Console.WriteLine(c1.ToString());
            } else
            {
                c1 = new ContaBancaria(nome, num_conta);
                Console.WriteLine(c1.ToString());
            }

            Console.WriteLine("Entre com um valor para depósito: ");
            double valor_deposito = double.Parse(Console.ReadLine());
            c1.ValorDepositado(valor_deposito);
            Console.WriteLine(c1.ToString());

            Console.WriteLine("Entre com um valor para saque: ");
            double valor_saque = double.Parse(Console.ReadLine());
            c1.ValorSaque(valor_saque);
            Console.WriteLine(c1.ToString());

        }
    }
}
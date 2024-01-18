using System;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ProjetoContaBancaria
{
    internal class ContaBancaria
    {
        public string Nome { get;  set; }
        public int Conta { get; private set; }
        public double Saldo { get; private set; }


        public ContaBancaria (string nome, int conta)
        {
            Nome = nome;
            Conta = conta;
        }

        public ContaBancaria (string nome, int conta, double saldo) : this(nome, conta)
        {
            Saldo = saldo;
        }

        public double ValorDepositado(double valor_depositado) { 
            return Saldo += valor_depositado;
        }

        public double ValorSaque(double valor_depositado)
        {
            return Saldo -= valor_depositado + 5;
        }

        public override string ToString()
        {
            return "Dados da conta \n"
                + "Conta: "
                + Conta
                + ", Titular: "
                + Nome 
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

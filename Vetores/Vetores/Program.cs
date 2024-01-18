using System;
using System.Globalization;
using Vetores;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double soma = 0;

            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nome do produto: ");
                string name = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product(name, price);

                soma += vect[i].Price;
            }

            double avg = soma / n;
            Console.WriteLine("AVERAGE PRICE: " + avg.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            
            Console.WriteLine("Você digitou: " + frase);
            Console.WriteLine("Você digitou: " + x);
            Console.WriteLine("Você digitou: " + y);
            Console.WriteLine("Você digitou: " + z);

            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            // string[] v = Console.ReadLine().Split(' '); 
            string p1 = vet[0]; 
            string p2 = vet[1]; 
            string p3 = vet[2];
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] n = Console.ReadLine().Split(' ');

            string nome = n[0];
            char sexo = char.Parse(n[1]);
            int idade = int.Parse(n[2]);
            double altura = double.Parse(n[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: " + n1);
            Console.WriteLine("Você digitou: " + ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            
            
        }
    }
}
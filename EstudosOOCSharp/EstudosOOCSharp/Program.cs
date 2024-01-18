using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Delcarar o Nullable... O '?' significa que é opcional
            double? x = null;
            double? y = 10.0;

            // Essa função pegar o valor padrão... Quando é null, é igual a 0
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            // Essa funçao determina se a variável tem valor ou não
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            } else
            {
                Console.WriteLine("X is Null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            } else
            {
                Console.WriteLine("Y is Null");
            }

            // Operador de Coalescência Nula ??
            Console.WriteLine("Operador de Coalescência Nula");
            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);



        }
    }
}
using System;

namespace EstudosCSharp
{
    internal class Aluno
    {
        public String nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double CalcularNota()
        {
            return nota1 + nota2 + nota3;
        }
    }
}

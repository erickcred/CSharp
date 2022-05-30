using System;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Operacoes.Soma(v1, v2);
            Operacoes.Subtracao(v1, v2);
            Operacoes.Divisao(v1, v2);
            Operacoes.Multiplicacao(v1, v2);
        }
    }
}

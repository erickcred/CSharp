namespace Calculator
{
    public class Operacoes
    {
        public static void Soma(float v1, float v2)
        {
            Console.WriteLine();
            Console.WriteLine("O resultado da soma de {0} + {1} = {2}", v1, v2, (v1 + v2));
        }

        public static void Subtracao(float v1, float v2)
        {
            Console.WriteLine();
            Console.WriteLine("O resultado da subtração de {0} - {1} = {2}", v1, v2, (v1 - v2));
        }
        public static void Divisao(float v1, float v2)
        {
            Console.WriteLine();
            if (v2 == 0)
            {
                Console.WriteLine("Não é possível fazer uma divisão por 0");
            }
            Console.WriteLine("Resultado da divisão de {0} / {1} = {2}", v1, v2, (v1 / v2));
        }
        public static void Multiplicacao(float v1, float v2)
        {
            Console.WriteLine();
            Console.WriteLine("O resultado da multiplicação entre {0} x {1} = {2}", v1, v2, (v1 * v2));
        }


    }
}
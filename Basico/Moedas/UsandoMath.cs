using System;
using System.Globalization;

namespace Moedas
{
    public class UsandoMath
    {
        public static void Start()
        {
            decimal valor = 10536.55m;

            Console.Clear();

            Console.WriteLine("Valor (Abs) Absoluto: " + Math.Abs(valor).ToString("C"));
            Console.WriteLine("Valor (Round) Arredondado pela media: " + Math.Round(valor).ToString("C"));
            Console.WriteLine("Valor (Ceiling) Arredondado sempre pra cima: " + Math.Ceiling(valor).ToString("C"));
            Console.WriteLine("valor (Truncate) Arredondado sempre pra baixo: " + Math.Truncate(valor).ToString("C"));
            Console.WriteLine("Valor (Floor) Arredondado para sempre para baixo: " + Math.Floor(valor).ToString("C"));
        }
    }
}
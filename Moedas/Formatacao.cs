using System;
using System.Globalization;

namespace Moedas
{
    public class Formatacao
    {
        public static void Start()
        {
            Console.WriteLine("Formatação de moédas: ");
            decimal valor = 10.25m;

            Console.Clear();

            Console.WriteLine(valor.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
        }
    }
}
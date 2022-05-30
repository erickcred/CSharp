using System;
using System.Globalization;

namespace Moedas 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10.25m;

            Console.WriteLine(valor);
            Console.WriteLine(valor.ToString("F2", CultureInfo.CurrentCulture));
            Console.WriteLine(valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
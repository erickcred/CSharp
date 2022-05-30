using System;

namespace DateTimes
{
    public class AdicionandoValores
    {
        public static void Start()
        {
            Console.Clear();

            DateTime data = DateTime.Now;

            Console.WriteLine("DataAtual: " + data);
            Console.WriteLine();
            Console.WriteLine("Mais 10 dias: " + data.AddDays(10));
            Console.WriteLine("Menos 5 dias: " + data.AddDays(-5));
        }
    }
}
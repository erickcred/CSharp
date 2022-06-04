using System;

namespace Delegates
{
    public class Program
    {
        // Delegates => Anonymous Methods

        static void RealizarPagamento(double valor)
        {
            Console.Clear();
            // Toda a validação aqui 
            Console.WriteLine($"Pagamento feito no valor de {valor.ToString("C")}");
        }

        public static void Main(string[] args)
        {
            var pag = new Pagamento.Pagar(RealizarPagamento);
            pag(30);
            
        }
    }
}
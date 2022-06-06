using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
                No .NET nos temos o List, ICollection, IEnumerable, IReadOnlyCollection
                IEnumerable => para somente leitura
                IList, ICollection => Tem todas as assões
            */
            List<Payment> payments = new List<Payment>();
            payments.Add(new Payment(1));
            payments.Add(new Payment(2));
            payments.Add(new Payment(3));
            payments.Add(new Payment(4));
            payments.Add(new Payment(5));

            Console.Clear();
            Console.WriteLine("Lista 1");
            ListPayment(payments);

            Console.WriteLine("\nLista 2");
            var paidPayments = new List<Payment>();
            paidPayments.AddRange(payments);
            ListPayment(paidPayments);

            Console.WriteLine("\nListando Pagamentos");
            // pegando elemento da lista
            var payment = payments.Find(p => p.Id == 2);
            Console.WriteLine($"Retorno da Pesquisa (Find): {payment.Id}");

            var payment2 = payments.First(p => p.Id == 3);
            Console.WriteLine($"Retorno da Pesquisa (First): {payment2.Id}");

            var payment3 = payments.Where(p => p.Id == 4);
            foreach (var p in payment3)
            {
                Console.WriteLine($"Retorno da Pesquisa (Where -> return list): {p.Id}");
            }

            Console.WriteLine("\nRemovendo itens da lista:");
            payments.Remove(payment2);
            ListPayment(payments);

            var count = payments.Count();
            Console.WriteLine(count);
        }

        public static void ListPayment(List<Payment> obj)
        {
            foreach (var payment in obj)
            {
                Console.WriteLine($"Payment: {payment.Id}");
            }
        }
    }
}
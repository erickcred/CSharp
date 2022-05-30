using System;

namespace DateTimes
{
    public class ComparandoDatas
    {
        public static void Show()
        {
            DateTime? dataAtual = null; // Data recebendo null
            DateTime data = DateTime.Now;

            Console.Clear();
            Console.WriteLine("Data atual com Null: " + dataAtual);

            // Se comparamos data == DateTime.Now ele vai retornar false, pois a comparação le toda a estrutura incluindo milisegundos;
            if (data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É igual");
                Console.WriteLine(data + " - " + DateTime.Now);
            } else 
            {
                Console.WriteLine("Não é igual");
                Console.WriteLine(data + " - " + DateTime.Now);
            }
        }
    }
}
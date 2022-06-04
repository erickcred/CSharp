using System;
using System.Text;

namespace Guids
{
    public class Metodos
    {
        // Alguns metodos uteis
        public void Exemplo()
        {
            string texto = "Este texto é um teste";

            Console.Clear();
            Console.WriteLine($"Texto Original => {texto}");
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.Insert(0, "1 "));
            Console.WriteLine(texto.Remove(4, 6));
            Console.WriteLine(texto.Length);
            Console.WriteLine(texto.Replace(" ", "-"));
            Console.WriteLine(texto.Replace("Este", "Isto"));

            var textoDividido = texto.Split(" ");
            Console.WriteLine("Transformando o texto em array(lista)");
            foreach (string data in textoDividido)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("-----");

            Console.WriteLine(texto.Substring(0, 4));
            
            Console.WriteLine("\n--- StringBuilder ---");
            StringBuilder sb = new StringBuilder();
            sb.Append(texto);
            sb.AppendLine();
            sb.Append("Mais um conteúdo adicionado pelo StringBuilder");
            Console.WriteLine(sb);
        }
    }
}
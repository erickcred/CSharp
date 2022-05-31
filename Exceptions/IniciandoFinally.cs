using System;

namespace Exceptions
{
    public class IniciandoFinally
    {
        public static void Start()
        {
            Console.Clear();
            try
            {
                Cadastrar(null);
            } catch (MinhaException erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.QuandoAconteceu);
            } finally
            {
                Console.WriteLine("Finalizando o processo!");
            }
        }

        private static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new MinhaException("O texto não pode ser Null ou Vazio!");
            }
        }

        public class MinhaException : Exception
        {
            public DateTime QuandoAconteceu { get; set; }
            public MinhaException(string message) : base(message) 
            {
                QuandoAconteceu = DateTime.Now;
            }
        }
    }
}
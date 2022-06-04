using System;

namespace Exceptions
{
    public class DisparandoExceptions
    {
        public static void Start()
        {
            Console.Clear();
            try
            {
                Cadastrar("asdf" + null);
            } catch (ArgumentNullException erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine("Falha ao cadastraro texto!");
            } catch (Exception erro)
            {
                Console.WriteLine("Ops! Algo deu errado.");
                Console.WriteLine(erro.Message);
            }
        }

        public static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new ArgumentNullException("O texto não poder ser null ou vazio!");
            }
        }
    }
}
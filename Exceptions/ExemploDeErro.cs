using System;

namespace Exceptions
{
    public class ExemploDeErro
    {
        public static void Start()
        {
            int[] array = new int[3];

            Console.Clear();
            try{
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(array[i]);
                }
            } catch (IndexOutOfRangeException erro)
            {
                Console.WriteLine(erro.InnerException);
                Console.WriteLine(erro.Message);
                Console.WriteLine("Não encontrei o índice na lista.");
            } catch (Exception erro)
            {
                Console.WriteLine(erro.InnerException);
                Console.WriteLine(erro.Message);
                Console.WriteLine("Ops! Algo de errado.");
            }
        }
    }
}
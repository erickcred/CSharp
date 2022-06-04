using System;
using System.IO;

namespace TextEditor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine(
                "O que você deseja fazer?" +
                "\n1 - Abrir arquivo" +
                "\n2 - Criar novo arquivo" +
                "\n0 - Sair"
            );

            try
            {
                short option = short.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Abrir();
                        break;
                    case 2:
                        Editar();
                        break;
                    case 0:
                        Console.WriteLine("Finalizando aplicação!");
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção invalida!\nTente novamente.");
                        Thread.Sleep(2000);
                        Menu();
                        break;
                }

            } catch (FormatException erro)
            {
                Console.WriteLine("Dado invalido!\n Tente novamente.");
                Thread.Sleep(2000);
                Menu();
            }

        }
    
        public static void Abrir()
        {
            // Console.WriteLine("Abrindo arquivo!");
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");

            string path = Console.ReadLine();
            
            using (var str = new StreamReader(path))
            {
                string text = "";
                text += str.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.WriteLine();
            Console.ReadLine();
            Menu();
        }

        public static void Editar()
        {
            // Console.WriteLine("Editando ou Criando o Arquivo!");
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo. (ESC para sair)");
            Console.WriteLine("-------------\n");

            string text = "";
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Salvar(text);
        }

        public static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var path = Console.ReadLine();
            Console.WriteLine("Qual o nome do Arquivo?");
            var file = Console.ReadLine();

            using (var stm = new StreamWriter(@$"{path}\{file}.txt"))
            {
                stm.Write(text);
            }
            Console.WriteLine(@"Arquivo salvo com sucesso em {0}\{1}.txt", path, file);
            Thread.Sleep(3500);
            Menu();
        }
    }
}
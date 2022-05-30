using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            
            DrawScreen(10, 30);
            WriteOptions();

            try
            {
                short option =  short.Parse(Console.ReadLine());
                HandleMenuOption(option);
            } catch (FormatException error)
            {
                Console.WriteLine($"Erro: Dado invalido");
                Thread.Sleep(1000);
                Show();
            }
        }

        public static void DrawScreen(int lines, int columns)
        {
            Columns(columns);
            Lines(lines, columns);
            Columns(columns);
        }

        public static void Columns(int columns)
        {
            Console.Write("+");
            for (int i = 0; i <= columns; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }

        public static void Lines(int lines, int columns)
        {
            for (int i = 0; i <= lines; i++)
            {
                Console.Write("|");
                for (int j = 0; j <= columns; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
        }
    
        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("=============");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("Selecione uma opção abaixo!");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("1 - Novo arquivo.");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("2 - Abrir.");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair.");
            Console.SetCursorPosition(3, 9);
            Console.Write("Opção: ");
        }
    
        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1:
                    Thread.Sleep(1000);
                    Editor.Show();
                    break;
                case 2:
                    Console.WriteLine("Abrindo arquivo");
                    Thread.Sleep(1000);
                    break;
                case 0:
                    Console.WriteLine("Finalizando a Aplicação!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Show();
                    break;
            }
        }
    
    }
}
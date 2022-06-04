using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Modo Editor\n(ESC) para sair.\n-----------");
            Start();
        }

        public static void Start()
        {
            StringBuilder file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            try{
                SaveMenu(file);
            } catch (FormatException erro)
            {
                SaveMenu(file);
            }
        }

        public static void SaveMenu(StringBuilder text)
        {
            Console.WriteLine("-------");
            Console.WriteLine("Desseja Salvar o arquivo? (s - sim | n - não)");

            char optionSave = Convert.ToChar(Console.ReadLine().ToLower());

            switch (optionSave)
            {
                case 's':
                    Save(text);
                    break;
                case 'n':
                    Console.WriteLine("Voltanto para o Menu Principal!");
                    Thread.Sleep(1500);
                    Menu.Show();
                    break;
                default:
                    Console.WriteLine("Entrada invalida tente novamente");
                    Thread.Sleep(1500);
                    SaveMenu(text);
                    break;
            }
            
        }
        
        public static void Save(StringBuilder text)
        {
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            string path = Console.ReadLine();
            Console.WriteLine("Qual o nome para o arquivo?");
            string fileName = Console.ReadLine();

            using (var stm = new StreamWriter($@"{path}\{fileName}.txt"))
            {
                stm.WriteAsync(text);
            }
            
            Console.WriteLine("Sanvando Arquivo..");
            Thread.Sleep(1500);
            Console.WriteLine(@$"Arquivo salvo em.. {path}\{fileName}.text");
            Thread.Sleep(1500);
            
            Console.WriteLine();
            Viewer.Show(text.ToString());
            Menu.Show();
        }
    }
}
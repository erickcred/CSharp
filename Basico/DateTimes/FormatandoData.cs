using System;

namespace DateTimes
{
    public class FormatandoData
    {
        public static void Start()
        {
            DateTime dataAtual = DateTime.Now;

            string formatada = String.Format("{0:dd/MM/yyyy HH:mm:ss}", dataAtual);
            string formatada2 = String.Format("{0}/{1}/{2}", dataAtual.Day, dataAtual.Month, dataAtual.Year);
            string formatada3 = dataAtual.ToString("dd/MM/yyyy");
            Console.WriteLine();


            // Rodando horas e segundos
            // int currentTime = 0;
            // double tim = 1 * 1000 * 3.6; // Horas
            // int time = 1 * 60; // Minitutos
            // int times = 10; // Segundos

            // while (currentTime != tim + 1)
            // {
            //     dataAtual = DateTime.Now;
            //     Console.WriteLine("Data atual: " + dataAtual);
            //     Console.WriteLine("String.Format Simple: " + formatada);
            //     Console.WriteLine("String.Format: " + formatada2);
            //     Console.WriteLine("ToString: " + formatada3);
            //     Thread.Sleep(1000);
            //     Console.Clear();

            //     Console.WriteLine(currentTime);
            //     Console.WriteLine("Time: " + tim);
            //     currentTime++;
            // }

            Console.WriteLine("mostrando somente a hora: " + String.Format("{0:t}", dataAtual));
            Console.WriteLine("Mostrando somente a data: " + String.Format("{0:d}", dataAtual));
            Console.WriteLine("mostrando somente a hora completa: " + String.Format("{0:T}", dataAtual));
            Console.WriteLine("Mostrando somente a data completa exteço: " + String.Format("{0:D}", dataAtual));
            Console.WriteLine("Mostrando data e hora completo: " + String.Format("{0:G}", dataAtual));
            Console.WriteLine("Mostrando data complera e hora curta: " + String.Format("{0:g}", dataAtual));
            Console.WriteLine("Mostrando data extenço e hota completa: " + String.Format("{0:F}", dataAtual));
            Console.WriteLine("Mostrando data extenço e hora curta" + String.Format("{0:f}", dataAtual));
        }
    }
}
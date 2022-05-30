using System;

namespace DateTimes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime data = new DateTime(2022, 05, 28, 10, 20, 00); // struct
            DateTime data2 = DateTime.Now; // Data atual
            Console.Clear();

            Console.WriteLine(data);
            Console.WriteLine(data2);
            Console.WriteLine(data.DayOfWeek); // dia da semana

            Console.WriteLine("Formatando Datas");
            // FormatandoData.Start();

            // ComparandoDatas.Show();

            // AdicionandoValores.Start();

            // CultureInfos.Start();

            // Timezones.Start();

            TimeSpans.Start();
        }
    }
}
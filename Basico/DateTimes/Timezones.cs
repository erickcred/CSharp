using System;
using System.Globalization;

namespace DateTimes
{
    public class Timezones
    {
        public static void Start()
        {
            Console.Clear();

            DateTime dataLocal = DateTime.Now; // hora do servidor
            DateTime dataUniversal = DateTime.UtcNow; // Hora Universal

            Console.WriteLine("Data do Servidor: " + dataLocal);
            Console.WriteLine("Data Universal: " + dataUniversal);

            Console.WriteLine("Processo que apresenta data Local do servidor: " + dataUniversal.ToLocalTime());

            // Para poder mostrar a data da maquina local do usuario
            Console.WriteLine();
            TimeZoneInfo timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timeZoneAustralia);
            DateTime dataAustralia = TimeZoneInfo.ConvertTimeFromUtc(dataUniversal, timeZoneAustralia);

            Console.WriteLine("Data Local da maquia por Timezone: " + dataAustralia);

            // Como listar todos os TimeZones
            var timeZones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timeZone in timeZones)
            {
                Console.WriteLine($"id = {timeZone.Id}");
                Console.WriteLine($"timeZone = {timeZone}");
                Console.WriteLine($"timeZoneInfo = {TimeZoneInfo.ConvertTimeFromUtc(dataUniversal, timeZone)}");
                Console.WriteLine("-------");
            }
        }
    }
}
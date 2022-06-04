using System;

namespace DateTimes
{
    public class TimeSpans
    {
        // Timespan Unidade de medida para datas 
        public static void Start()
        {
            TimeSpan timeSpan = new TimeSpan();
            
            Console.Clear();

            Console.WriteLine(timeSpan);
            Console.WriteLine("Nano segundos: " + new TimeSpan(1));
            Console.WriteLine("Hora Minuto Segundo: " + new TimeSpan(5, 12, 8));
            Console.WriteLine("Dia Hora Minuto Segundo: " + new TimeSpan(3, 5, 12, 8));
            Console.WriteLine("Dia Hora Minuto Segundo Milissegundos: " + new TimeSpan(3, 5, 12, 8, 100));
        }
    }
}
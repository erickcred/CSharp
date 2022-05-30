using System;
using System.Globalization;

namespace DateTimes
{
    public class CultureInfos
    {
        public static void Start()
        {
            Console.Clear();

            CultureInfo pt = new CultureInfo("pt-BR"); // Brasil
            CultureInfo ptp = new CultureInfo("pt-PT"); // Portugal
            CultureInfo us = new CultureInfo("en-US"); // Estados Unidos
            CultureInfo usb = new CultureInfo("en-UK"); // Britanico
            CultureInfo de = new CultureInfo("de-DE"); // Dinamarca

            Console.WriteLine("Brasil: " + DateTime.Now.ToString("D", pt));
            Console.WriteLine("Portugal: " + DateTime.Now.ToString("D", ptp));
            Console.WriteLine("Estados Unidos: " + DateTime.Now.ToString("D", us));
            Console.WriteLine("Britanico: " + DateTime.Now.ToString("D", usb));
            Console.WriteLine("Dinamarca: " + DateTime.Now.ToString("D", de));
        }
    }
}
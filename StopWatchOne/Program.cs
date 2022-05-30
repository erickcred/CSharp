using System;
using System.Globalization;

namespace StopWatch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        public static void PreStart(int time)
        {
            Console.Clear();
            Console.Write("Ready...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("Set...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("Gooooo");
            Thread.Sleep(1500);
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine(
                "S = Segundo => 10s" +
                "\nM = Minuto => 10m" +
                "\n0 = Sair" +
                "\nQuanto tempo deseja contar?"
            );
            string data = Console.ReadLine().ToLower();
            char type = Convert.ToChar(data.Substring(data.Length -1));
            int time = Convert.ToInt32(data.Substring(0, data.Length -1));
            int second = 1;

            if (type == 'm')
            {
                second = 60;
            }
            if (time == 0) System.Environment.Exit(0);

            PreStart(time);
            Start(time * second);
        }

        public static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time + 1)
            {
                Console.Clear();
                Console.WriteLine(currentTime);
                Console.WriteLine(DateTime.Now.Hour+":"+DateTime.Now.Minute.ToString()+":"+DateTime.Now.Second);
                Thread.Sleep(1000); // 1000 Milliseconds
                currentTime++;
            }
        }
    }
}
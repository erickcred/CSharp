namespace StopWatch
{
    public class Menu
    {
        public static void Start()
        {
            Console.WriteLine("Infome qual o tempo \n(10s - segundos | 10m - minutos)");
            string value = Console.ReadLine();
            char type = Convert.ToChar(value.Substring(value.Length - 1));
            int time = Convert.ToInt32(value.Substring(0, value.Length -1));

            Timer(time, type);
        }

        public static void Timer(int time, char type)
        {
            int currentTime = 0;
            DateTime dateStart = DateTime.Now;

            if (type == 'm')
            {
                int calc = time * 60;
                time = calc;
            }

            while (currentTime != time + 1)
            {
                DateTime date = DateTime.Now;
             
                Console.Clear();
                Console.WriteLine($"Iniciado em {dateStart} com Tempo de {time}s");
                Console.WriteLine(date);
                Thread.Sleep(1000);
                currentTime++;
            }
        }
    }
}
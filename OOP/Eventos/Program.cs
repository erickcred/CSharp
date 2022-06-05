using System;

namespace Eventos
{
    public class Program
    {
        public static void Main(string[] ags)
        {
            Console.Clear();

            Sala sala = new Sala(3);
            sala.SalaLotadaEvento += SalaLotada;

            sala.ResenvarSala();
            sala.ResenvarSala();
            sala.ResenvarSala();
            sala.ResenvarSala();
        }

        public static void SalaLotada(object snder, EventArgs e)
        {
            Console.WriteLine("Sala Lotada!");
        }
    }
}
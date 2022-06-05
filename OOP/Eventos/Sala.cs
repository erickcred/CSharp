using System;

namespace Eventos
{
    public class Sala
    {
        public int Assentos { get; set; }
        
        private int AssentosEmUso = 0;

        public Sala(int assentos)
        {
            Assentos = assentos;
            AssentosEmUso = 0;
        }

        public void ResenvarSala()
        {
            if (AssentosEmUso >= Assentos)
            {
                // Evento Fechado
                AoSalaLotada(EventArgs.Empty);
            } else 
            {
                Console.WriteLine("Assento reservado!");
            }
         
            AssentosEmUso++;
        }

        public event EventHandler SalaLotadaEvento;

        protected virtual void AoSalaLotada(EventArgs e)
        {
            EventHandler evento = SalaLotadaEvento;
            evento?.Invoke(this, e);
        }
    }
}
using System;

using System;

namespace JogoDadoCorreto
{
    public class Dado
    {
        protected int lado;
        protected static Random random = new Random();

        public Dado()
        {
            lado = 0;
        }

        public int Lado
        {
            get => lado;
            set => lado = value;
        }

        public int JogaDado()
        {
            int jogar = random.Next(1, 7);
            Console.WriteLine("Dado: {0}", jogar);
            return jogar;
        }
    }
}

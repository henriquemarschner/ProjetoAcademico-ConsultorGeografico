using System;

using System;

namespace JogoDadoCorreto
{
    public class Jogador : Pessoa
    {
        protected int pts;

        public Jogador() : base()
        {
            pts = 0;
        }

        public Jogador(string nome, int pts) : base(nome, 0, '\0')
        {
            this.pts = pts;
        }

        public int Pts
        {
            get => pts;
            set => pts = value;
        }

        public void JogaDado(Dado oDado)
        {
            int ponto = 0;
            do
            {
                ponto = oDado.JogaDado();
                pts += ponto;
                Console.WriteLine("Jogador {0} - Pontos obtidos nesta jogada: {1} - Total: {2}", Nome, ponto, pts);
            }
            while (ponto == 1 || ponto == 6);
        }
    }
}

using System;

using System;

namespace JogoDadoCorreto
{
    public class Jogo
    {
        protected Jogador ojogador1;
        protected Jogador ojogador2;
        protected Dado odado;

        public Jogo()
        {
            ojogador1 = new Jogador();
            ojogador2 = new Jogador();
            odado = new Dado();
        }

        public Dado Dado
        {
            get => odado;
            set => odado = value;
        }

        public Jogador Jogador1
        {
            get => ojogador1;
            set => ojogador1 = value;
        }

        public Jogador Jogador2
        {
            get => ojogador2;
            set => ojogador2 = value;
        }

        public void Jogar(Inter aInter)
        {
            do
            {
                ojogador1.JogaDado(odado);
                if (ojogador1.Pts >= 100) break;
                ojogador2.JogaDado(odado);
            }
            while (ojogador1.Pts < 100 && ojogador2.Pts < 100);

            if (ojogador1.Pts >= 100)
                aInter.MostraVencedor(ojogador1.Nome, ojogador1.Pts);
            else
                aInter.MostraVencedor(ojogador2.Nome, ojogador2.Pts);
        }

        public void Executar(Inter aInter)
        {
            string nome1 = aInter.PecaJogador();
            string nome2 = aInter.PecaJogador();

            int inicial = odado.JogaDado();
            if (inicial <= 3)
            {
                ojogador1.Nome = nome1;
                ojogador2.Nome = nome2;
                aInter.MostraQuemInicia(ojogador1.Nome);
            }
            else
            {
                ojogador1.Nome = nome2;
                ojogador2.Nome = nome1;
                aInter.MostraQuemInicia(ojogador1.Nome);
            }

            Jogar(aInter);
        }
    }
}

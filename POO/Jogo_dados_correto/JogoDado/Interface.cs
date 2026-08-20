using System;

using System;

namespace JogoDadoCorreto
{
    public class Inter
    {
        public Inter()
        {
        }

        public string PecaJogador()
        {
            Console.Write("Digite o nome do jogador: ");
            string nome = Console.ReadLine() ?? string.Empty;
            return nome.Trim();
        }

        public void MostraQuemInicia(string nome)
        {
            Console.WriteLine("Quem inicia: {0}", nome);
        }

        public void MostraVencedor(string nome, int pontos)
        {
            Console.WriteLine("Vencedor: {0} com {1} pontos!", nome, pontos);
        }
    }
}

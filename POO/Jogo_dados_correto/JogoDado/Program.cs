using System;
using System;

namespace JogoDadoCorreto
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var inter = new Inter();
            var jogo = new Jogo();

            jogo.Executar(inter);

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}

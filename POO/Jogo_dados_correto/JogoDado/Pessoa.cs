using System;

namespace JogoDadoCorreto
{
    public class Pessoa
    {
        protected string nome;
        protected char sexo;
        protected double idd;

        public Pessoa()
        {
            nome = string.Empty;
            idd = 0;
            sexo = '\0';
        }

        public Pessoa(string nome, double idd, char sexo)
        {
            this.nome = nome;
            this.idd = idd;
            this.sexo = sexo;
        }

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public char Sexo
        {
            get => sexo;
            set => sexo = value;
        }

        public double Idd
        {
            get => idd;
            set => idd = value;
        }
    }
}

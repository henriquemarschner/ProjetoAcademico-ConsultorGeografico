using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPaises
{
    public class Pessoa
    {
        protected int idade;
        protected string nome;
        protected char sexo;

        public Pessoa()
        {
            idade = 0;
            nome = "";
            sexo = ' ';
        }

        public Pessoa(int idade, string nome, char sexo)
        {
            this.idade = idade;
            this.nome = nome;
            this.sexo = sexo;
        }

        public int Idade
        {
            get => idade;
            set => idade = value;
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

        public Pessoa Clone()
        {
            return new Pessoa(idade, nome, sexo);
        }
    }
}

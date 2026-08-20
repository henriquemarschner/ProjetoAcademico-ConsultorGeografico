using System;

namespace ConsultaPaises
{
    public class Funcionario : Pessoa
    {
        protected int salBase;
        protected char cargo;
        protected char cnh;
        protected int numDep;

        public Funcionario() : base()
        {
            salBase = 0;
            cargo = ' ';
            cnh = ' ';
            numDep = 0;
        }

        public Funcionario(int idade, string nome, char sexo, int salBase, char cargo, char cnh, int numDep) : base(idade, nome, sexo)
        {
            this.salBase = salBase;
            this.cargo = cargo;
            this.cnh = cnh;
            this.numDep = numDep;
        }

        public int SalBase
        {
            get => salBase;
            set => salBase = value;
        }

        public char Cargo
        {
            get => cargo;
            set => cargo = value;
        }

        public char Cnh
        {
            get => cnh;
            set => cnh = value;
        }

        public int NumDep
        {
            get => numDep;
            set => numDep = value;
        }
    }
}


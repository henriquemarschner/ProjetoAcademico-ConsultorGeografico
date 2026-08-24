using System;

namespace ConsultaPaises
{
    public class Funcionario : Pessoa
    {
        protected double salBase;
        protected char cargo;
        protected char tipoCNH;
        protected int nCNH;
        protected int numDep;
        protected int mat;
        protected double grat;
        /// 
        protected string cep;
        protected string bairro;
        protected string complemento;
        protected int numero;
        protected string endereco;
        protected Cidades aCidade;
        /// 
        protected DateTime validade;

        public Funcionario() : base()
        {
            salBase = 0;
            cargo = ' ';
            tipoCNH = ' ';
            nCNH = 0;
            numDep = 0;
            mat = 0;
            grat = 0;
            cep = "";
            bairro = "";
            complemento = "";
            numero = 0;
            endereco = "";
            aCidade = new Cidades();
        }

        public Funcionario(int idade, string nome, char sexo, double salBase, char cargo, char tipoCNH, int nCNH, int numDep, int mat, double grat, string cep, string bairro, string complemento, int numero, string endereco, Cidades aCidade) : base(idade, nome, sexo)
        {
            this.salBase = salBase;
            this.cargo = cargo;
            this.tipoCNH = tipoCNH;
            this.nCNH = nCNH;
            this.numDep = numDep;
            this.mat = mat;
            this.grat = grat;
            this.cep = cep;
            this.bairro = bairro;
            this.complemento = complemento;
            this.numero = numero;
            this.endereco = endereco;
            this.aCidade = aCidade;
        }

        public new Funcionario Clone()
        {
            return new Funcionario(idade, nome, sexo, salBase, cargo, tipoCNH, nCNH, numDep, mat, grat, cep, bairro, complemento, numero, endereco, aCidade);
        }

        public double SalBase
        {
            get => salBase;
            set => salBase = value;
        }

        public char Cargo
        {
            get => cargo;
            set => cargo = value;
        }

        public char TipoCNH
        {
            get => tipoCNH;
            set => tipoCNH = value;
        }

        public int NCNH
        {
            get => nCNH;
            set => nCNH = value;
        }

        public int NumDep
        {
            get => numDep;
            set => numDep = value;
        }

        public int Mat
        {
            get => mat;
            set => mat = value;
        }

        public double Grat
        {
            get => grat;
            set => grat = value;
        }

        public string Cep
        {
            get => cep;
            set => cep = value;
        }

        public string Bairro
        {
            get => bairro;
            set => bairro = value;
        }

        public string Complemento
        {
            get => complemento;
            set => complemento = value;
        }

        public int Numero
        {
            get => numero;
            set => numero = value;
        }

        public string Endereco
        {
            get => endereco;
            set => endereco = value;
        }

        public DateTime Validade
        {
            get => validade;
            set => validade = value;
        }
    }
}


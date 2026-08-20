using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPaises
{
    internal class Cidades : Pai
    {
        protected string cidade;
        protected Estados oEstado;

        public Cidades() : base()
        {
            cidade = "";
            oEstado = new Estados();
        }

        public Cidades(int codigo, int codUsu, DateTime datCad, DateTime ultAlt, string cidade, Estados oEstado) : base(codigo, codUsu, datCad, ultAlt)
        {
            this.cidade = cidade;
            this.oEstado = oEstado;
        }

        public string Cidade
        {
            get => cidade;
            set => cidade = value;
        }

        public Estados OEstado
        {
            get => oEstado;
            set => oEstado = value;
        }
    }
}

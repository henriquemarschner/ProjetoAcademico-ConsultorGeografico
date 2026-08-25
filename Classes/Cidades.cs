using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPaises
{
    public class Cidades : Pai
    {
        protected string cidade;
        protected int ddd;
        protected Estados oEstado;

        public Cidades() : base()
        {
            cidade = "";
            ddd = 0;
            oEstado = new Estados();
        }

        public Cidades(int codigo, int codUsu, DateTime datCad, DateTime ultAlt, string cidade, Estados oEstado, int ddd) : base(codigo, codUsu, datCad, ultAlt)
        {
            this.cidade = cidade;
            this.oEstado = oEstado;
            this.ddd = ddd;
        }

        public string Cidade
        {
            get => cidade;
            set => cidade = value;
        }

        public int DDD
        {
            get => ddd;
            set => ddd = value;
        }

        public Estados OEstado
        {
            get => oEstado;
            set => oEstado = value;
        }

        public new Cidades Clone()
        {
            return new Cidades(this.Codigo, this.CodUsu, this.DatCad, this.UltAlt, this.cidade, (Estados)oEstado.Clone(), this.ddd);
        }
    }
}

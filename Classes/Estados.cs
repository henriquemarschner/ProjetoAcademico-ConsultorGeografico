using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPaises
{
    internal class Estados : Pai
    {
        protected string uf;
        protected string estado;
        protected Paises oPais;
        
        public Estados() : base() 
        {
            estado = "";
            uf = "";
            oPais = new Paises();
        }

        public Estados(int codigo, int codUsu, DateTime datCad, DateTime UltAlt, string estado,  string uf, Paises oPais) : base(codigo,codUsu,datCad,UltAlt) 
        {
            this.estado = estado;
            this.uf = uf;
            this.oPais = oPais;
        }

        public string Estado
        {
            get => estado;
            set => estado = value;
        }

        public string UF
        {
            get => uf;
            set => uf = value;
        }

        public Paises Opais
        {
            get => oPais;
            set => oPais = value;
        }

    }
}

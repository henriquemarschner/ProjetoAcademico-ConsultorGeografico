using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPaises
{
    public class Paises : Pai
    {
        protected string pais;
        protected string sigla;
        protected string ddi;
        protected string moeda;

        public Paises() : base()
        {
            pais = "";
            sigla = "";
            ddi = "";
            moeda = "";
        }

        public Paises(int cod, int codUsu, DateTime datCad, DateTime ultAlt, string pais, string sigla, string ddi, string moeda) : base(cod, codUsu, datCad, ultAlt)
        {
            this.pais = pais;
            this.sigla = sigla;
            this.ddi = ddi;
            this.moeda = moeda;
        }

        public new Paises Clone()
        {
            return new Paises(cod, codUsu, datCad, ultAlt, pais, sigla, ddi, moeda);
        }

        public string Pais
        {
            get => pais;
            set => pais = value;
        }

        public string Sigla
        {
            get => sigla;
            set => sigla = value;
        }

        public string Ddi
        {
            get => ddi;
            set => ddi = value;
        }

        public string Moeda
        {
            get => moeda;
            set => moeda = value;
        }
    }

}

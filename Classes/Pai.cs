using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPaises
{
    public class Pai
    {
        protected int cod;
        protected int codUsu;
        protected DateTime datCad;
        protected DateTime ultAlt;

        public Pai()
        {
            cod = 0;
            codUsu = 0;
            datCad = DateTime.Now;
            ultAlt = DateTime.Now;
        }

        public Pai(int cod, int codUsu, DateTime datCad, DateTime ultAlt)
        {
            this.cod = cod;
            this.codUsu = codUsu;
            this.datCad = datCad;
            this.ultAlt = ultAlt;
        }

        public Pai Clone()
        {
            return new Pai(cod, codUsu, datCad, ultAlt);
        }

        public int Codigo
        {
            get => cod;
            set => cod = value;
        }

        public int CodUsu
        {
            get => codUsu;
            set => codUsu = value;
        }

        public DateTime DatCad
        {
            get => datCad;
            set => datCad = value;
        }

        public DateTime UltAlt
        {
            get => ultAlt;
            set => ultAlt = value;
        }


    }
}

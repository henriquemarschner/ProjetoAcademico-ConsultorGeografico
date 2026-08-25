using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPaises.Classes
{
    public class Cargo
    {
        protected char exigeCNH;
        protected char cargo;

        public Cargo()
        {
            exigeCNH = ' ';
            cargo = ' ';
        }
        public Cargo(char exigeCNH, char cargo)
        {
            this.exigeCNH = exigeCNH;
            this.cargo = cargo;
        }

        public char ExigeCNH
        {
            get => exigeCNH;
            set => exigeCNH = value;
        }

        public char Cargos
        {
            get => cargo;
            set => cargo = value;
        }
    }
}

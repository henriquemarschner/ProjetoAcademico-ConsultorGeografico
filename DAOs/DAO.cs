using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPaises
{
    public abstract class DAO
    {
        public DAO()
        {
        }

        public abstract string CarregaObj(Object obj);

        public abstract string Salvar(Object obj);

        public abstract string CarregaTudo(Object obj);

        public abstract string Excluir(Object obj);
    }
}

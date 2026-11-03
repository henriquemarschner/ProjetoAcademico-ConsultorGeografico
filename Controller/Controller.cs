using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPaises.Controller
{
    public abstract class Controller
    {
        public abstract string CarregarObj(object obj);

        public abstract List<Object> CarregarCol(object obj);

        public abstract string Salvar(object obj);

        public abstract string Excluir(object obj);

        public abstract List<Object> Pesquisar(object obj);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPaises
{
    internal class ControllerEstados: Controller
    {
        ControllerPaises aControllerPais;

        public ControllerEstados()
        {
            aControllerPais = new ControllerPaises();
        }
        public override string CarregarObj(object obj)
        {
            return null;
        }

        public override string Salvar(object obj)
        {
            return null;
        }

        public override string Excluir(object obj)
        {
            return null;
        }

        public override List<Object> Pesquisar(object obj)
        {
            return null;
        }
    }
}

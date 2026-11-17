using ConsultaPaises.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPaises.Controller
{
        public class ControllerCidades : Controller
        {
            ControllerPaises aControllerPais;
            ControllerEstados aControllerEstado;
            protected DAOCidades aDAOCidades;
            protected DAOestados aDAOEstados;
            public DAOpaises aDAOPaises;

            public ControllerCidades()
            {
                aControllerPais = new ControllerPaises();
                aControllerEstado = new ControllerEstados();
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

                public override List<Object> CarregarCol(object obj)
                {
                    return null;
                }
        }
}

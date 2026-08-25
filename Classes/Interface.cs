using ConsultaPaises.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPaises
{
    public class Interface
    {
        protected FrmConPaises oFrmConPaises;
        protected FrmConEstados oFrmConEstados;
        protected FrmConCid oFrmConCid;
        protected FrmCadPaises oFrmCadPaises;
        protected FrmCadEstados oFrmCadEstados;
        protected FrmCadCid oFrmCadCid;
        protected ControllerPaises aControllerPaises;
        protected ControllerEstados aControllerEstados;
        protected ControllerCidades aControllerCidades;

        public Interface()
        {
            oFrmConPaises = new FrmConPaises();
            oFrmConEstados = new FrmConEstados();
            oFrmConCid = new FrmConCid();

            oFrmCadPaises = new FrmCadPaises();
            oFrmCadEstados = new FrmCadEstados();
            oFrmCadCid = new FrmCadCid();

            oFrmConPaises.setFrmCadastro(oFrmCadPaises);
            oFrmConEstados.setFrmCadastro(oFrmCadEstados);
            oFrmConCid.setFrmCadastro(oFrmCadCid);

            oFrmCadEstados.setFrmConsultas(oFrmConPaises);
            oFrmCadCid.setFrmConsultas(oFrmConEstados);
        }

        public void PecaPaises(object obj, object ctrl)
        {
            oFrmConPaises.ConhecaObjeto(obj, aControllerPaises);
            oFrmConPaises.ShowDialog();
        }

        public void PecaEstados(object obj, object ctrl)
        {
            oFrmConEstados.ConhecaObjeto(obj, aControllerEstados);
            oFrmConEstados.ShowDialog();
        }

        public void PecaCidades(object obj, object ctrl)
        {
            oFrmConCid.ConhecaObjeto(obj, aControllerCidades);
            oFrmConCid.ShowDialog();
        }
    }
}

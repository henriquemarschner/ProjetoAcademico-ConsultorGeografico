using ConsultaPaises;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConsultaPaises
{
    public partial class FrmConEstados : ConsultaPaises.FrmConsultas
    {
        Estados oEstado;
        FrmCadEstados oFrmCadEstados;
        public FrmConEstados()
        {
            InitializeComponent();
        }

        public override void ConhecaObjeto(object obj, object ctrl)
        {
            oEstado = (Estados)obj;
        }

        public override void setFrmCadastro(object obj)
        {
            oFrmCadEstados = (FrmCadEstados)obj;
        }

        public override void Incluir()
        {
            oFrmCadEstados.ConhecaObjeto(oEstado, null);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.ShowDialog();
        }

        public override void Alterar()
        {
            oFrmCadEstados.ConhecaObjeto(oEstado, null);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.ShowDialog();
        }

        public override void Excluir()
        {
            string aux;
            aux = oFrmCadEstados.btnSalva.Text;
            oFrmCadEstados.btnSalva.Text = "Excluir";
            oFrmCadEstados.ConhecaObjeto(oEstado, null);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.BloqueiaTxt();
            oFrmCadEstados.ShowDialog();
            oFrmCadEstados.DesbloqueiaTxt();
            oFrmCadEstados.btnSalva.Text = aux;
        }

        public override void Pesquisar()
        {

        }

    }
}

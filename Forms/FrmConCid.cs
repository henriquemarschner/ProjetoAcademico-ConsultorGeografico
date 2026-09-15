using ConsultaPaises.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConsultaPaises
{
    public partial class FrmConCid : ConsultaPaises.FrmConsultas
    {
        Cidades aCidade;
        FrmCadCidades oFrmCadCid;
        ControllerCidades aCtrlCidades;
        public FrmConCid()
        {
            InitializeComponent();
        }
        public override void ConhecaObjeto(object obj, object ctrl)
        {
            aCidade = (Cidades)obj;
            aCtrlCidades = (ControllerCidades)ctrl;
        }
        public override void Incluir()
        {
            oFrmCadCid.ConhecaObjeto(aCidade, aCtrlCidades);
            oFrmCadCid.LimpaTxt();
            oFrmCadCid.CarregaTxt();
            oFrmCadCid.ShowDialog();
        }
        public override void Alterar()
        {
            oFrmCadCid.ConhecaObjeto(aCidade, aCtrlCidades);
            oFrmCadCid.LimpaTxt();
            oFrmCadCid.CarregaTxt();
            oFrmCadCid.ShowDialog();
        }

        public override void Excluir()
        {
            string aux = oFrmCadCid.btnSalva.Text;
            oFrmCadCid.btnSalva.Text = "Executar";
            oFrmCadCid.ConhecaObjeto(aCidade, aCtrlCidades);
            oFrmCadCid.LimpaTxt();
            oFrmCadCid.CarregaTxt();
            oFrmCadCid.BloqueiaTxt();
            oFrmCadCid.ShowDialog();
            oFrmCadCid.btnSalva.Text = aux;
            oFrmCadCid.DesbloqueiaTxt();
        }

        public override void Pesquisar()
        {

        }
        public override void setFrmCadastro(object obj)
        {
            oFrmCadCid = (FrmCadCidades)obj;
        }

        private void FrmConCid_Load(object sender, EventArgs e)
        {


        }
    }
}

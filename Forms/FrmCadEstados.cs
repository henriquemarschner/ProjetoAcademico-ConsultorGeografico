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
    public partial class FrmCadEstados : ConsultaPaises.FrmCad
    {
        FrmConPaises oFrmConPaises;
        Estados oEstado;
        ControllerEstados aCtrlEstados;
        ControllerPaises aCtrlPaises;
        public FrmCadEstados()
        {
            InitializeComponent();
            aCtrlPaises = new ControllerPaises();
        }

        public override void ConhecaObjeto(object obj, object ctrl)
        {
            oEstado = (Estados)obj;
            aCtrlEstados = (ControllerEstados)ctrl;
        }
        public override void setFrmConsultas(object obj)
        {
            oFrmConPaises = (FrmConPaises)obj;
        }

        public override void LimpaTxt()
        {
            this.txtCod.Clear();
            this.txtUF.Clear();
            this.txtPais.Clear();
            this.txtEstado.Clear();
            this.txtCodPais.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(oEstado.Codigo);
            txtUF.Text = oEstado.UF;
            txtEstado.Text = oEstado.Estado;
            txtPais.Text = oEstado.Opais.Pais;
            txtCodPais.Text = Convert.ToString(oEstado.Opais.Codigo);
        }

        public override void BloqueiaTxt()
        {

        }

        public override void DesbloqueiaTxt()
        {

        }

        public override void Salvar()
        {
            if(this.txtEstado.Text == "" || this.txtEstado.Text == null)
                this.txtEstado.Focus();
            if(this.txtUF.Text == "" || this.txtUF.Text == null)
                this.txtUF.Focus();
            if(this.txtPais.Text == "" || this.txtPais.Text == null)
                this.txtPais.Focus();
            oEstado.Codigo = Convert.ToInt32(this.txtCod.Text);
            oEstado.UF = this.txtUF.Text;
            oEstado.Estado = this.txtEstado.Text;
            oEstado.Opais.Pais = this.txtPais.Text;
            oEstado.Opais.Codigo = Convert.ToInt32(this.txtCodPais.Text);
            this.Sair();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string aux = oFrmConPaises.btnSair.Text;
            string aux2 = "UF*";
            oFrmConPaises.btnSair.Text = "Selecionar";
            oFrmConPaises.ConhecaObjeto(oEstado.Opais , aCtrlPaises);
            oFrmConPaises.ShowDialog();
            this.txtCodPais.Text = Convert.ToString(oEstado.Opais.Codigo);
            this.txtPais.Text = oEstado.Opais.Pais;
            if (oEstado.Opais.Sigla == "BR")
            {
                this.lblUF.Text = aux2;
            }
            oFrmConPaises.btnSair.Text = aux;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
        }
    }
}

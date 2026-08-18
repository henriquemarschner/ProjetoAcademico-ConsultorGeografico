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
        public FrmCadEstados()
        {
            InitializeComponent();
        }

        public override void ConhecaObjeto(object obj, object ctrl)
        {
            oEstado = (Estados)obj;
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
            oEstado.Codigo = Convert.ToInt32(this.txtCod.Text);
            oEstado.UF = this.txtUF.Text;
            oEstado.Estado = this.txtEstado.Text;
            oEstado.Opais.Pais = this.txtPais.Text;
            oEstado.Opais.Codigo = Convert.ToInt32(this.txtCodPais.Text);
            this.Sair();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            oFrmConPaises.ConhecaObjeto(oEstado.Opais ,null);
            oFrmConPaises.ShowDialog();
        }
    }
}

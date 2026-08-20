using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConsultaPaises
{
    public partial class FrmCadPaises : ConsultaPaises.FrmCad
    {
        private Paises oPais;
        public FrmCadPaises()
        {
            InitializeComponent();
        }
        public override void ConhecaObjeto(object obj, object ctrl)
        {
            oPais = (Paises)obj;
        }

        public override void LimpaTxt()
        {
            this.txtCod.Clear();
            this.lblCodUsu.Text = string.Empty;
            this.lblDatCad.Text = string.Empty;
            this.lblUltAlt.Text = string.Empty;
        }

        public override void CarregaTxt()
        {
            this.txtCod.Text = Convert.ToString(oPais.Codigo);
            this.lblCodUsu.Text = Convert.ToString(oPais.CodUsu);
            this.lblDatCad.Text = Convert.ToString(oPais.DatCad);
            this.lblUltAlt.Text = Convert.ToString(oPais.UltAlt);
        }

        public override void BloqueiaTxt()
        {
            this.txtCod.Enabled = false;
            this.txtPais.Enabled = false;
            this.txtSigla.Enabled = false;
            this.txtDDI.Enabled = false;
            this.txtMoeda.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            this.txtCod.Enabled = true;
            this.txtPais.Enabled = true;
            this.txtSigla.Enabled = true;
            this.txtDDI.Enabled = true;
            this.txtMoeda.Enabled = true;
        }

        public override void setFrmConsultas(object obj)
        {

        }

        public override void Salvar()
        {
            oPais.Pais = this.txtPais.Text;
            oPais.Sigla = this.txtSigla.Text;
            oPais.Ddi = this.txtDDI.Text;
            oPais.Moeda = this.txtMoeda.Text;
            this.Sair();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void lblCodUsu_Click(object sender, EventArgs e)
        {

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConsultaPaises
{
    public partial class FrmConsultas : ConsultaPaises.FrmBase
    {
        public FrmConsultas()
        {
            InitializeComponent();
            // Conectar eventos manualmente
            if (this.btnExcluir != null)
                this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
        }

        public virtual void Incluir()
        {

        }

        public virtual void Alterar()
        {

        }

        public virtual void Excluir()
        {

        }

        public virtual void Pesquisar()
        {

        }

        public virtual void BloqueiaTxt()
        {

        }

        public virtual void DesbloqueiaTxt()
        {

        }

        public virtual void setFrmCadastro(object obj)
        {

        }

        protected void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

    }
}
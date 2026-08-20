using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConsultaPaises
{
    public partial class FrmCadCid : ConsultaPaises.FrmCad
    {
        Cidades oCidade;
        FrmConEstados oFrmConEstados;

        public FrmCadCid()
        {
            InitializeComponent();
        }

        public override void ConhecaObjeto(object obj, object ctrl)
        {
            oCidade = (Cidades)obj;
        }

        public override void setFrmConsultas(object obj)
        {
            oFrmConEstados = (FrmConEstados)obj;
        }

        public override void LimpaTxt()
        {
            this.txtCod.Clear();
        }

        public override void CarregaTxt()
        {
            txtCod.Text = Convert.ToString(oCidade.Codigo);
        }

        public override void BloqueiaTxt()
        {
        }

        public override void DesbloqueiaTxt()
        {
        }

        public override void Salvar()
        {
            oCidade.Codigo = Convert.ToInt32(this.txtCod.Text);
            this.Sair();
        }
    }
}

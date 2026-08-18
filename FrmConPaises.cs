using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConsultaPaises
{
    public partial class FrmConPaises : ConsultaPaises.FrmConsultas
    {
        FrmCadPaises oFrmCadPaises;
        Paises oPais;
        public FrmConPaises()
        {
            InitializeComponent();
        }

        public override void ConhecaObjeto(object obj, object ctrl)
        {
               oPais = (Paises)obj;
        }

        public override void setFrmCadastro(object obj)
        {
            oFrmCadPaises = (FrmCadPaises)obj;
        }

        public override void Incluir()
        {
            oFrmCadPaises.ConhecaObjeto(oPais, null);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
        }

        public override void Alterar()
        {
            oFrmCadPaises.ConhecaObjeto(oPais, null);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
        }

        public override void Excluir()
        {
            string aux;
            aux = oFrmCadPaises.btnSalva.Text;
            oFrmCadPaises.btnSalva.Text = "Excluir";
            oFrmCadPaises.ConhecaObjeto(oPais, null);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.BloqueiaTxt();
            oFrmCadPaises.ShowDialog();
            oFrmCadPaises.DesbloqueiaTxt();
            oFrmCadPaises.btnSalva.Text = aux;
        }

        public override void Pesquisar()
        {

        }

    }
}

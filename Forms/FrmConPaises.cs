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
    public partial class FrmConPaises : ConsultaPaises.FrmConsultas
    {
        FrmCadPaises oFrmCadPaises;
        Paises oPais;
        ControllerPaises aCtrlPaises;
        public FrmConPaises()
        {
            InitializeComponent();
        }

        public override void ConhecaObjeto(object obj, object ctrl)
        {
            oPais = (Paises)obj;
            aCtrlPaises = (ControllerPaises)ctrl;
            this.Pesquisar();
        }

        public override void setFrmCadastro(object obj)
        {
            oFrmCadPaises = (FrmCadPaises)obj;
        }

        public override void Incluir()
        {
            oFrmCadPaises.ConhecaObjeto(oPais, aCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
        }

        public override void Alterar()
        {
            oFrmCadPaises.ConhecaObjeto(oPais, aCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
        }

        public override void Excluir()
        {
            string aux;
            aux = oFrmCadPaises.btnSalva.Text;
            oFrmCadPaises.btnSalva.Text = "Excluir";
            oFrmCadPaises.ConhecaObjeto(oPais, aCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.BloqueiaTxt();
            oFrmCadPaises.ShowDialog();
            oFrmCadPaises.DesbloqueiaTxt();
            oFrmCadPaises.btnSalva.Text = aux;
        }

        public override void Pesquisar()
        {
            this.LV.Items.Clear();
            //   Paises oP = new Paises();
            oPais.Pais = txtCod.Text.Trim().ToUpper();
            var listaResultado = new List<Paises>();
            //   listaResultado = aCtrlPaises.Pesquisar(oP);
            foreach (var o in aCtrlPaises.Pesquisar(oPais))
            {
                listaResultado.Add((Paises)o);
            }

            foreach (var oPais in listaResultado)
            {
                ListViewItem item = new ListViewItem(".");
                item.SubItems.Add(oPais.Pais);
                item.SubItems.Add(oPais.Sigla);
                item.SubItems.Add(oPais.Ddi);
                item.SubItems.Add(oPais.Moeda);
                this.LV.Items.Add(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaPaises
{
    public partial class FrmPrincipal : Form
    {
        private Interface aInter;
        private Paises oPais;
        private Estados oEstado;
        private Cidades aCidade;
        public FrmPrincipal()
        {
            InitializeComponent();
            aInter = new Interface();
            oPais = new Paises();
            oEstado = new Estados();
            aCidade = new Cidades();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaEstados(oEstado, null);
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaCidades(aCidade, null);
        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaPaises(oPais, null);
        }
    }
}

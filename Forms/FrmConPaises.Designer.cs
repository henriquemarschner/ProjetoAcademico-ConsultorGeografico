namespace ConsultaPaises
{
    partial class FrmConPaises
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.n = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSig = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDDI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColMoeda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LV
            // 
            this.LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.n,
            this.Codigo,
            this.colPais,
            this.colSig,
            this.colDDI,
            this.ColMoeda});
            this.LV.GridLines = true;
            this.LV.View = System.Windows.Forms.View.Details;
            // 
            // n
            // 
            this.n.Text = ".";
            this.n.Width = 10;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Codigo";
            this.Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colPais
            // 
            this.colPais.Text = "Pais";
            // 
            // colSig
            // 
            this.colSig.Text = "Sigla";
            this.colSig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSig.Width = 80;
            // 
            // colDDI
            // 
            this.colDDI.Text = "DDI";
            this.colDDI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDDI.Width = 80;
            // 
            // ColMoeda
            // 
            this.ColMoeda.Text = "Moeda";
            // 
            // FrmConPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Name = "FrmConPaises";
            this.Text = "Consulta de Paises";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ColumnHeader n;
        protected System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader colDDI;
        protected System.Windows.Forms.ColumnHeader colPais;
        protected System.Windows.Forms.ColumnHeader colSig;
        protected System.Windows.Forms.ColumnHeader ColMoeda;
    }
}

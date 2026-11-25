namespace ConsultaPaises
{
    partial class FrmConEstados
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
            this.colN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LV
            // 
            this.LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colN,
            this.colCod,
            this.colEst,
            this.colUF,
            this.colCodPais,
            this.colPais});
            this.LV.GridLines = true;
            this.LV.View = System.Windows.Forms.View.Details;
            // 
            // colN
            // 
            this.colN.Text = "n";
            this.colN.Width = 10;
            // 
            // colCod
            // 
            this.colCod.Text = "Codigo";
            this.colCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colEst
            // 
            this.colEst.Text = "Estado";
            // 
            // colUF
            // 
            this.colUF.Text = "UF";
            // 
            // colCodPais
            // 
            this.colCodPais.Text = "Codigo Pais";
            this.colCodPais.Width = 80;
            // 
            // colPais
            // 
            this.colPais.Text = "Pais";
            // 
            // FrmConEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Name = "FrmConEstados";
            this.Text = "Consulta de Estados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ColumnHeader colN;
        protected System.Windows.Forms.ColumnHeader colCod;
        protected System.Windows.Forms.ColumnHeader colEst;
        protected System.Windows.Forms.ColumnHeader colUF;
        protected System.Windows.Forms.ColumnHeader colCodPais;
        protected System.Windows.Forms.ColumnHeader colPais;
    }
}

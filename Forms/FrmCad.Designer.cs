namespace ConsultaPaises
{
    partial class FrmCad
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
            this.btnSalva = new System.Windows.Forms.Button();
            this.lblDatCadlbl = new System.Windows.Forms.Label();
            this.lblUltAltlbl = new System.Windows.Forms.Label();
            this.lblCodUsulbl = new System.Windows.Forms.Label();
            this.lblDatCad = new System.Windows.Forms.Label();
            this.lblUltAlt = new System.Windows.Forms.Label();
            this.lblCodUsu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(611, 402);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 3;
            this.btnSalva.Text = "&Salvar";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // lblDatCadlbl
            // 
            this.lblDatCadlbl.AutoSize = true;
            this.lblDatCadlbl.Location = new System.Drawing.Point(12, 425);
            this.lblDatCadlbl.Name = "lblDatCadlbl";
            this.lblDatCadlbl.Size = new System.Drawing.Size(97, 16);
            this.lblDatCadlbl.TabIndex = 4;
            this.lblDatCadlbl.Text = "Data Cadastro:";
            // 
            // lblUltAltlbl
            // 
            this.lblUltAltlbl.AutoSize = true;
            this.lblUltAltlbl.Location = new System.Drawing.Point(11, 402);
            this.lblUltAltlbl.Name = "lblUltAltlbl";
            this.lblUltAltlbl.Size = new System.Drawing.Size(109, 16);
            this.lblUltAltlbl.TabIndex = 4;
            this.lblUltAltlbl.Text = "Ultima Alteração:";
            // 
            // lblCodUsulbl
            // 
            this.lblCodUsulbl.AutoSize = true;
            this.lblCodUsulbl.Location = new System.Drawing.Point(12, 379);
            this.lblCodUsulbl.Name = "lblCodUsulbl";
            this.lblCodUsulbl.Size = new System.Drawing.Size(104, 16);
            this.lblCodUsulbl.TabIndex = 4;
            this.lblCodUsulbl.Text = "Código Usuário:";
            this.lblCodUsulbl.Click += new System.EventHandler(this.lblCodUsu_Click);
            // 
            // lblDatCad
            // 
            this.lblDatCad.AutoSize = true;
            this.lblDatCad.Location = new System.Drawing.Point(115, 425);
            this.lblDatCad.Name = "lblDatCad";
            this.lblDatCad.Size = new System.Drawing.Size(0, 16);
            this.lblDatCad.TabIndex = 4;
            // 
            // lblUltAlt
            // 
            this.lblUltAlt.AutoSize = true;
            this.lblUltAlt.Location = new System.Drawing.Point(127, 402);
            this.lblUltAlt.Name = "lblUltAlt";
            this.lblUltAlt.Size = new System.Drawing.Size(0, 16);
            this.lblUltAlt.TabIndex = 4;
            // 
            // lblCodUsu
            // 
            this.lblCodUsu.AutoSize = true;
            this.lblCodUsu.Location = new System.Drawing.Point(122, 379);
            this.lblCodUsu.Name = "lblCodUsu";
            this.lblCodUsu.Size = new System.Drawing.Size(0, 16);
            this.lblCodUsu.TabIndex = 4;
            this.lblCodUsu.Click += new System.EventHandler(this.lblCodUsu_Click);
            // 
            // FrmCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCodUsu);
            this.Controls.Add(this.lblCodUsulbl);
            this.Controls.Add(this.lblUltAlt);
            this.Controls.Add(this.lblUltAltlbl);
            this.Controls.Add(this.lblDatCad);
            this.Controls.Add(this.lblDatCadlbl);
            this.Controls.Add(this.btnSalva);
            this.Name = "FrmCad";
            this.Text = "Cadastro";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalva, 0);
            this.Controls.SetChildIndex(this.lblDatCadlbl, 0);
            this.Controls.SetChildIndex(this.lblDatCad, 0);
            this.Controls.SetChildIndex(this.lblUltAltlbl, 0);
            this.Controls.SetChildIndex(this.lblUltAlt, 0);
            this.Controls.SetChildIndex(this.lblCodUsulbl, 0);
            this.Controls.SetChildIndex(this.lblCodUsu, 0);
            this.Controls.SetChildIndex(this.lblTxt, 0);
            this.Controls.SetChildIndex(this.txtCod, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnSalvar;
        protected System.Windows.Forms.Label lblDatCadlbl;
        protected System.Windows.Forms.Label lblCodUsulbl;
        protected System.Windows.Forms.Label lblUltAltlbl;
        protected System.Windows.Forms.Label lblDatCad;
        protected System.Windows.Forms.Label lblUltAlt;
        protected System.Windows.Forms.Label lblCodUsu;
        public System.Windows.Forms.Button btnSalva;
    }
}

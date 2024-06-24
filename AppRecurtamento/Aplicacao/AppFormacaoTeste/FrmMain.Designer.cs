namespace AppFormacaoTeste
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpProdutos = new System.Windows.Forms.GroupBox();
            this.grdListaProdutos = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAbrirDetalhe = new System.Windows.Forms.Button();
            this.grpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpProdutos
            // 
            this.grpProdutos.Controls.Add(this.grdListaProdutos);
            this.grpProdutos.Location = new System.Drawing.Point(11, 6);
            this.grpProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.grpProdutos.Name = "grpProdutos";
            this.grpProdutos.Padding = new System.Windows.Forms.Padding(4);
            this.grpProdutos.Size = new System.Drawing.Size(896, 497);
            this.grpProdutos.TabIndex = 0;
            this.grpProdutos.TabStop = false;
            this.grpProdutos.Text = "Lista Produtos";
            // 
            // grdListaProdutos
            // 
            this.grdListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaProdutos.Location = new System.Drawing.Point(8, 23);
            this.grdListaProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.grdListaProdutos.Name = "grdListaProdutos";
            this.grdListaProdutos.RowHeadersWidth = 51;
            this.grdListaProdutos.Size = new System.Drawing.Size(880, 466);
            this.grdListaProdutos.TabIndex = 0;
            this.grdListaProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaProdutos_CellContentClick);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.Location = new System.Drawing.Point(799, 511);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 28);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(583, 511);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAbrirDetalhe
            // 
            this.btnAbrirDetalhe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirDetalhe.Location = new System.Drawing.Point(691, 511);
            this.btnAbrirDetalhe.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrirDetalhe.Name = "btnAbrirDetalhe";
            this.btnAbrirDetalhe.Size = new System.Drawing.Size(100, 28);
            this.btnAbrirDetalhe.TabIndex = 4;
            this.btnAbrirDetalhe.Text = "Abrir";
            this.btnAbrirDetalhe.UseVisualStyleBackColor = true;
            this.btnAbrirDetalhe.Click += new System.EventHandler(this.btnAbrirDetalhe_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 554);
            this.Controls.Add(this.btnAbrirDetalhe);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.grpProdutos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Lista Produtos";
            this.grpProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListaProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProdutos;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAbrirDetalhe;
        private System.Windows.Forms.DataGridView grdListaProdutos;
    }
}
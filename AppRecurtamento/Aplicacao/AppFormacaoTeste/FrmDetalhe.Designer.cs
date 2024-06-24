namespace AppFormacaoTeste
{
    partial class FrmDetalhe
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gprProduto = new System.Windows.Forms.GroupBox();
            this.dateTimeAtualizacao = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCriacao = new System.Windows.Forms.DateTimePicker();
            this.comboBoxFamilia = new System.Windows.Forms.ComboBox();
            this.txtUltimoPreco = new System.Windows.Forms.TextBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gprProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(621, 375);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(513, 375);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gprProduto
            // 
            this.gprProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gprProduto.Controls.Add(this.dateTimeAtualizacao);
            this.gprProduto.Controls.Add(this.dateTimeCriacao);
            this.gprProduto.Controls.Add(this.comboBoxFamilia);
            this.gprProduto.Controls.Add(this.txtUltimoPreco);
            this.gprProduto.Controls.Add(this.txtNomeProd);
            this.gprProduto.Controls.Add(this.label5);
            this.gprProduto.Controls.Add(this.txtCodProduto);
            this.gprProduto.Controls.Add(this.label7);
            this.gprProduto.Controls.Add(this.label6);
            this.gprProduto.Controls.Add(this.chkActivo);
            this.gprProduto.Controls.Add(this.richTextBox1);
            this.gprProduto.Controls.Add(this.label4);
            this.gprProduto.Controls.Add(this.label3);
            this.gprProduto.Controls.Add(this.label2);
            this.gprProduto.Controls.Add(this.label1);
            this.gprProduto.Location = new System.Drawing.Point(16, 15);
            this.gprProduto.Margin = new System.Windows.Forms.Padding(4);
            this.gprProduto.Name = "gprProduto";
            this.gprProduto.Padding = new System.Windows.Forms.Padding(4);
            this.gprProduto.Size = new System.Drawing.Size(705, 353);
            this.gprProduto.TabIndex = 2;
            this.gprProduto.TabStop = false;
            this.gprProduto.Text = "Produto";
            // 
            // dateTimeAtualizacao
            // 
            this.dateTimeAtualizacao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dateTimeAtualizacao.CustomFormat = "dd-MM-yyyy";
            this.dateTimeAtualizacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeAtualizacao.Location = new System.Drawing.Point(158, 120);
            this.dateTimeAtualizacao.Name = "dateTimeAtualizacao";
            this.dateTimeAtualizacao.Size = new System.Drawing.Size(132, 22);
            this.dateTimeAtualizacao.TabIndex = 23;
            // 
            // dateTimeCriacao
            // 
            this.dateTimeCriacao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dateTimeCriacao.CustomFormat = "dd-MM-yyyy";
            this.dateTimeCriacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeCriacao.Location = new System.Drawing.Point(11, 119);
            this.dateTimeCriacao.Name = "dateTimeCriacao";
            this.dateTimeCriacao.Size = new System.Drawing.Size(125, 22);
            this.dateTimeCriacao.TabIndex = 22;
            // 
            // comboBoxFamilia
            // 
            this.comboBoxFamilia.FormattingEnabled = true;
            this.comboBoxFamilia.Location = new System.Drawing.Point(426, 48);
            this.comboBoxFamilia.Name = "comboBoxFamilia";
            this.comboBoxFamilia.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFamilia.TabIndex = 20;
            // 
            // txtUltimoPreco
            // 
            this.txtUltimoPreco.Location = new System.Drawing.Point(426, 121);
            this.txtUltimoPreco.Margin = new System.Windows.Forms.Padding(4);
            this.txtUltimoPreco.Name = "txtUltimoPreco";
            this.txtUltimoPreco.Size = new System.Drawing.Size(121, 22);
            this.txtUltimoPreco.TabIndex = 19;
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Location = new System.Drawing.Point(158, 50);
            this.txtNomeProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(132, 22);
            this.txtNomeProd.TabIndex = 18;
            this.txtNomeProd.TextChanged += new System.EventHandler(this.textNomeProd_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Data atulização";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(4, 50);
            this.txtCodProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(132, 22);
            this.txtCodProduto.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ultimo preço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Data Criação";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(623, 54);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(4);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(66, 20);
            this.chkActivo.TabIndex = 6;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(8, 214);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(688, 138);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Familia (combox)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cód. Produto";
            // 
            // FrmDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 418);
            this.Controls.Add(this.gprProduto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDetalhe";
            this.Text = "Detalhe Produto";
            this.gprProduto.ResumeLayout(false);
            this.gprProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gprProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUltimoPreco;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.DateTimePicker dateTimeCriacao;
        private System.Windows.Forms.ComboBox comboBoxFamilia;
        private System.Windows.Forms.DateTimePicker dateTimeAtualizacao;
    }



}


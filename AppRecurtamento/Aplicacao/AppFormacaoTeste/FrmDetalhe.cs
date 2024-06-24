using AppFormacaoTeste.ADO;
using AppFormacaoTeste.modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppFormacaoTeste
{

    /// <summary>
    /// PONTOS A FAZER nor Formulario FrmDetalhe:
    ///    1 - Adicionar os inputs que estão em falta.
    ///    2 - Com base nos dados preenchidos, guardar os dados na base de dados:
    ///	        - Após guardar, limpar os inputs e fechar o formulário.
    ///	        - Garantir que não há códigos de produtos repetidos.
    ///     3 - Programar o botão cancelar. Quando for clicado deve limpar os dados dos inputs e fechar o formulário.
    /// </summary>
    public partial class FrmDetalhe : Form
    {

        bool edicao = false;
        public FrmDetalhe()
        {
            InitializeComponent();
            CarregarFamilias();
            this.txtCodProduto.ReadOnly = true;
        }

        public void DetalharProduto(Produto produto, bool edicao)
        {
            this.edicao = edicao;
            this.txtCodProduto.Text = produto.CodProduto.ToString();
            this.txtNomeProd.Text = produto.NomeProduto;
            this.chkActivo.Checked = produto.Activo;
            this.comboBoxFamilia.SelectedIndex = produto.IdFamilia - 1;
            this.comboBoxFamilia.DisplayMember = "NomeFamilia";
            this.dateTimeAtualizacao.Text = produto.DataAtualizacao.ToString();
            this.dateTimeCriacao.Text = produto.DataCriacao.ToString();
            this.txtUltimoPreco.Text = produto.UltimoPreco.ToString();
            this.richTextBox1.Text = produto.Descricao.ToString();


        }

        //Limpar os campos quando não deseja guardar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            decimal ultimoPreco;

            if (!decimal.TryParse(txtUltimoPreco.Text, out ultimoPreco))
            {
                MessageBox.Show("Valor de 'Último Preço' inválido.");
                return;
            }

            try
            {

                RepositorioProduto repositorio = new RepositorioProduto();

                if (!edicao)
                {
                    Produto novoProduto = new Produto(
                    txtNomeProd.Text,
                    (int)comboBoxFamilia.SelectedValue,
                    chkActivo.Checked,
                    dateTimeCriacao.Value,
                    dateTimeAtualizacao.Value,
                    ultimoPreco,
                    richTextBox1.Text
                );
                    repositorio.AdicionarProduto(novoProduto);
                }
                else
                {
                    Produto novoProduto = new Produto(
                        Convert.ToInt32(txtCodProduto.Text),
                        txtNomeProd.Text,
                        (int)comboBoxFamilia.SelectedValue,
                        chkActivo.Checked,
                        dateTimeCriacao.Value,
                        dateTimeAtualizacao.Value,
                        ultimoPreco,
                        richTextBox1.Text
                        );
                    repositorio.AtualizarProduto(novoProduto);
                }

                MessageBox.Show("Produto salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CarregarFamilias()
        {
            RepositorioProduto repositorio = new RepositorioProduto();
            List<Familia> familias = repositorio.ListarFamilias();

            comboBoxFamilia.DataSource = familias;
            comboBoxFamilia.ValueMember = "Id";
            comboBoxFamilia.DisplayMember = "NomeFamilia";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNomeProd_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

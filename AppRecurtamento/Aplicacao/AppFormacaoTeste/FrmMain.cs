using AppFormacaoTeste.ADO;
using AppFormacaoTeste.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFormacaoTeste
{
    /// <summary>
    /// </summary>
    public partial class FrmMain : Form
    {
        RepositorioProduto repositorio;
        public FrmMain()
        {
            InitializeComponent();

            repositorio = new RepositorioProduto();

            CarregarProdutos();

           
        }
        private void CarregarProdutos()
        {
            List<Produto> produtos = repositorio.ListarTodosProdutos();

            grdListaProdutos.DataSource = produtos;
            grdListaProdutos.ReadOnly = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmDetalhe frmDetalhe = new FrmDetalhe();
            frmDetalhe.ShowDialog();
            CarregarProdutos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codProduto;
            codProduto = Convert.ToInt32(grdListaProdutos.CurrentRow.Cells[0].Value);
            repositorio.EliminarProduto(codProduto);
            CarregarProdutos();
        }



        private void grdListaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAbrirDetalhe_Click(object sender, EventArgs e)
        {
            int codProduto;
            codProduto = Convert.ToInt32(grdListaProdutos.CurrentRow.Cells[0].Value);
            Produto produto = repositorio.DetalharProduto(codProduto);
            FrmDetalhe frmDetalhe = new FrmDetalhe();
            frmDetalhe.DetalharProduto(produto,true);
            frmDetalhe.ShowDialog();
            CarregarProdutos();
        }

    }
}

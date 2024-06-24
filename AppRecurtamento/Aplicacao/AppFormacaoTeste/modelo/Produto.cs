using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFormacaoTeste
{
    public class Produto
    {
        public int CodProduto { get; private set; }
        public string NomeProduto { get; private set; }
        public int IdFamilia { get; private set; }
        public bool Activo { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime DataAtualizacao { get; private set; }
        public decimal UltimoPreco { get; private set; }
        public string Descricao { get; private set; }

        public Produto()
        {
        }

        public Produto(int codProduto, string nomeProduto, int IdFamilia, bool activo,
            DateTime dataCriacao, DateTime dataAtualizacao, decimal ultimoPreco, string descricao)
        {
            this.CodProduto = codProduto;
            this.NomeProduto = nomeProduto;
            this.IdFamilia = IdFamilia;
            this.Activo = activo;
            this.DataCriacao = dataCriacao;
            this.DataAtualizacao = dataAtualizacao;
            this.UltimoPreco = ultimoPreco;
            this.Descricao = descricao;
        }

        public Produto(string nomeProduto, int idFamilia, bool activo, DateTime dataCriacao, DateTime dataAtualizacao, decimal ultimoPreco, string descricao)
        {
            NomeProduto = nomeProduto;
            IdFamilia = idFamilia;
            Activo = activo;
            DataCriacao = dataCriacao;
            DataAtualizacao = dataAtualizacao;
            UltimoPreco = ultimoPreco;
            Descricao = descricao;
        }
    }
}

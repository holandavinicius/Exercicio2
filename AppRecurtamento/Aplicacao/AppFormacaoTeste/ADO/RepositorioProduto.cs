using AppFormacaoTeste.modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace AppFormacaoTeste.ADO
{
    public class RepositorioProduto
    {
        private readonly string connectionString;


        public RepositorioProduto()
        {
            connectionString = Properties.Settings.Default.AppBDConnectionString;
        }

        public List<Produto> ListarTodosProdutos()
        {
            List<Produto> todosProdutos = new List<Produto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM tbProdutos";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Produto produto = new Produto(
                        (int)reader["CodProduto"],
                        (string)reader["NomeProduto"],
                        (int)reader["IdFamilia"],
                        (bool)reader["Activo"],
                        (DateTime)reader["DataCriacao"],
                        (DateTime)reader["DataAtualizacao"],
                        (decimal)reader["UltimoPreco"],
                        (string)reader["Descricao"]);

                    todosProdutos.Add(produto);
                }
                connection.Close();
                return todosProdutos;

            }
        }

        public List<Familia> ListarFamilias()
        {
            List<Familia> familias = new List<Familia>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM tbFamilias";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Familia familia = new Familia(
                        (int)reader["Id"],
                        (string)reader["NomeFamilia"]
                        );

                    familias.Add(familia);
                }

                return familias;

            }
        }

        public void AdicionarProduto(Produto produto)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    string query = "INSERT INTO tbProdutos (NomeProduto, IdFamilia, Activo, DataCriacao, DataAtualizacao, UltimoPreco, Descricao) " +
                                   "VALUES (@NomeProduto, @IdFamilia, @Activo, @DataCriacao, @DataAtualizacao, @UltimoPreco, @Descricao)";

                    SqlCommand command = new SqlCommand(query, connection);


                    command.Parameters.AddWithValue("@NomeProduto", produto.NomeProduto);
                    command.Parameters.AddWithValue("@IdFamilia", produto.IdFamilia);
                    command.Parameters.AddWithValue("@Activo", produto.Activo);
                    command.Parameters.AddWithValue("@DataCriacao", produto.DataCriacao);
                    command.Parameters.AddWithValue("@DataAtualizacao", produto.DataAtualizacao);
                    command.Parameters.AddWithValue("@UltimoPreco", produto.UltimoPreco);
                    command.Parameters.AddWithValue("@Descricao", produto.Descricao);

                    connection.Open();
                    var reulst = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Erro ao executar a query: " + sqlEx.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void EliminarProduto(int codProduto)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    string query = "DELETE FROM tbProdutos WHERE @codProduto = codProduto";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@codProduto", codProduto);

                    connection.Open();
                    var reulst = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Erro ao executar a query: " + sqlEx.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Produto DetalharProduto(int codProduto)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    Produto orignial = new Produto();

                    string query = "SELECT * FROM tbProdutos WHERE @codProduto = codProduto";


                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@codProduto", codProduto);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();



                    while (reader.Read())
                    {
                        Produto produto = new Produto(
                            (int)reader["CodProduto"],
                            (string)reader["NomeProduto"],
                            (int)reader["IdFamilia"],
                            (bool)reader["Activo"],
                            (DateTime)reader["DataCriacao"],
                            (DateTime)reader["DataAtualizacao"],
                            (decimal)reader["UltimoPreco"],
                            (string)reader["Descricao"]);

                        orignial = produto;
                    }

                    connection.Close();
                    return orignial;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Erro ao executar a query: " + sqlEx.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        internal void AtualizarProduto(Produto produto)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    string query = "UPDATE tbProdutos SET NomeProduto = @NomeProduto, IdFamilia = @IdFamilia," +
                        " Activo = @Activo, DataCriacao = @DataCriacao, DataAtualizacao = @DataAtualizacao," +
                        " UltimoPreco = @UltimoPreco, Descricao = @Descricao WHERE codProduto = @codProduto";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@codProduto", produto.CodProduto);
                    command.Parameters.AddWithValue("@NomeProduto", produto.NomeProduto);
                    command.Parameters.AddWithValue("@IdFamilia", produto.IdFamilia);
                    command.Parameters.AddWithValue("@Activo", produto.Activo);
                    command.Parameters.AddWithValue("@DataCriacao", produto.DataCriacao);
                    command.Parameters.AddWithValue("@DataAtualizacao", produto.DataAtualizacao);
                    command.Parameters.AddWithValue("@UltimoPreco", produto.UltimoPreco);
                    command.Parameters.AddWithValue("@Descricao", produto.Descricao);

                    connection.Open();
                    var reulst = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Erro ao executar a query: " + sqlEx.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


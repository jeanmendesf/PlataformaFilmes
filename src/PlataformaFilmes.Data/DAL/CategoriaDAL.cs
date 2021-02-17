using PlataformaFilmes.Model.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PlataformaFilmes.Data.DAL
{
    public class CategoriaDAL
    {
        string connectionString = @"Data Source =  DESKTOP-9D3IEDO\SQLEXPRESS01;
                                    Initial Catalog = db_PlataformaVideos; Integrated Security=True";

        public List<Categoria> ObterTodasCategorias()
        {
            List<Categoria> lstCategorias = new List<Categoria>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.tbl_Categoria", connection);
                cmd.CommandType = CommandType.Text;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Filme> lstFilmes = new List<Filme>();

                while (reader.Read())
                {
                    Categoria categoria = new Categoria();

                    categoria.Id = Convert.ToInt32(reader["Id"]);
                    categoria.Nome = reader["Nome"].ToString();
                    categoria.Descricao = reader["Descricao"].ToString();
                    //categoria.Filmes = metodoPegarFilmePorCategoria
                    lstCategorias.Add(categoria);
                }
                return lstCategorias;
            }
        }


        public Categoria ObterCategoriaPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Categoria categoria = new Categoria();

                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.tbl_Categoria WHERE Id =" + id, connection);
                cmd.CommandType = CommandType.Text;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Filme> lstFilmes = new List<Filme>();

                while(reader.Read())
                {
                    categoria.Id = Convert.ToInt32(reader["Id"]);
                    categoria.Nome = reader["Nome"].ToString();
                    categoria.Descricao = reader["Descricao"].ToString();
                    //categoria.Filmes = metodoPegarFilmePorCategoria
                }
                return categoria;
            }
        }


        //Obtem mais de uma categoria passando uma lista de Ids
        public List<Categoria> ObterListaCategoriaPorId(List<int> idCategorias)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<Categoria> lstCategorias = new List<Categoria>();                 
                connection.Open();
                foreach (int  idCategoria in idCategorias)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.tbl_Categoria WHERE Id =" + idCategoria, connection);
                    cmd.CommandType = CommandType.Text;

                    SqlDataReader reader = cmd.ExecuteReader();
                    Categoria categoria = new Categoria();

                    while (reader.Read())
                    {
                        categoria.Id = Convert.ToInt32(reader["Id"]);
                        categoria.Nome = reader["Nome"].ToString();
                        categoria.Descricao = reader["Descricao"].ToString();
                        //categoria.Filmes = metodoPegarFilmePorCategoria
                    }

                    lstCategorias.Add(categoria);
                    reader.Close();
                }
                connection.Close();
                return lstCategorias;
            }
        }


        public void AdicionarCategoria(Categoria categoria)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.tbl_Categoria(Nome, Descricao)" +
                                                "VALUES (@Nome, @Descricao)", connection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", categoria.Nome);
                cmd.Parameters.AddWithValue("@Descricao", categoria.Descricao);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }



        //Pega todas categorias que tenham um filme de id 'N'
        public List<Categoria> ObterCategoriaPorFilme(int FilmeId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<int> lstIdsCategorias = new List<int>();

                SqlCommand cmd = new SqlCommand("SELECT CategoriaId FROM dbo.tbl_Filme_Categoria WHERE FilmeId = " + FilmeId, connection);
                cmd.CommandType = CommandType.Text;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int idCategoria = new int();

                    idCategoria = Convert.ToInt32(reader["CategoriaId"]);

                    lstIdsCategorias.Add(idCategoria);
                    
                }
                connection.Close();
                List<Categoria> lstCategorias = new List<Categoria>();
                lstCategorias = ObterListaCategoriaPorId(lstIdsCategorias);

                return lstCategorias;
            }
        }



    }
}

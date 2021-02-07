﻿using PlataformaFilmes.Model.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Transactions;

namespace PlataformaFilmes.Data.DAL
{
    public class FilmeDAL
    {
        string connectionString = @"Data Source =  DESKTOP-9D3IEDO\SQLEXPRESS01;
                                    Initial Catalog = db_PlataformaVideos; Integrated Security=True";


        public IEnumerable<Filme> ObterTodosFilmes()
        {
            List<Filme> lstFilmes = new List<Filme>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.tbl_Filme", connection);
                cmd.CommandType = CommandType.Text;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DiretorDAL diretorDAL = new DiretorDAL();

                while (reader.Read())
                {
                    Filme filme = new Filme();

                    filme.Id = Convert.ToInt32(reader["Id"]);
                    filme.Nome = reader["Nome"].ToString();
                    filme.Descricao = reader["Descricao"].ToString();
                    filme.DiretorId = Convert.ToInt32(reader["DiretorId"]);
                    filme.Diretor = diretorDAL.ObterDiretorPorId(Convert.ToInt32(reader["DiretorId"]));
                    lstFilmes.Add(filme);
                }
                return lstFilmes;
            }
        }


        public Filme ObterFilmePorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Filme filme = new Filme();

                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.tbl_Filme WHERE Id =" + id, connection);
                cmd.CommandType = CommandType.Text;


                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DiretorDAL diretorDAL = new DiretorDAL();

                while (reader.Read())
                {
                    filme.Id = Convert.ToInt32(reader["Id"]);
                    filme.Nome = reader["Nome"].ToString();
                    filme.Descricao = reader["Descricao"].ToString();
                    filme.DiretorId = Convert.ToInt32(reader["DiretorId"]);
                    filme.Diretor = diretorDAL.ObterDiretorPorId(Convert.ToInt32(reader["DiretorId"]));
                }
                return filme;
            }
        }


        public void AdicionarFilme(Filme filme)
        {
            using (var transactionScope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO dbo.tbl_Filme(Nome, Descricao, DiretorId) " +
                            "VALUES (@Nome, @Descricao, @DiretorId)" +
                            "SELECT SCOPE_IDENTITY() AS [ultimoID];", connection);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Nome", filme.Nome);
                        cmd.Parameters.AddWithValue("@Descricao", filme.Descricao);
                        cmd.Parameters.AddWithValue("@DiretorId", filme.DiretorId);

                        connection.Open();
                        //Adicionando Filme
                        //cmd.ExecuteNonQuery();

                        //Relacionando Filme e Categoria
                        int ultimoId = Convert.ToInt32(cmd.ExecuteScalar());

                        SqlCommand cmd2 = new SqlCommand("INSERT INTO dbo.tbl_Filme_Categoria(FilmeId, CategoriaId)" +
                                                "VALUES (@FilmeId, @CategoriaId)", connection);

                        cmd2.CommandType = CommandType.Text;

                        foreach (Categoria categoria in filme.Categorias)
                        {
                            cmd2.Parameters.AddWithValue("@FilmeId", ultimoId);
                            cmd2.Parameters.AddWithValue("@CategoriaId", categoria.Id);
                            cmd2.ExecuteNonQuery();
                            cmd2.Parameters.Clear();
                        }

                        transactionScope.Complete();
                        connection.Close();
                    }
                }
                catch (Exception)
                {
                    transactionScope.Dispose();
                }
            }
        }



        public void AtualizarFilme(Filme filme)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UPDATE dbo.tbl_Filme SET " +
                    "Nome=@Nome, Descricao=@Descricao, DiretorId=@DiretorId WHERE Id=@Id", connection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", filme.Id);
                cmd.Parameters.AddWithValue("@Nome", filme.Nome);
                cmd.Parameters.AddWithValue("@Descricao", filme.Descricao);
                cmd.Parameters.AddWithValue("@DiretorId", filme.DiretorId);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }


        public void DeletarFilme(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM dbo.tbl_Filme WHERE Id = @id", connection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", id);

                connection.Open();
                DeletarReferencia(id);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }


    public void DeletarReferencia(int filmeId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM dbo.tbl_Filme_Categoria WHERE FilmeId = @filmeId", connection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@filmeId", filmeId);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }



    }
}

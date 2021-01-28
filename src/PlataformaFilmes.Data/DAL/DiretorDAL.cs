using PlataformaFilmes.Model.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PlataformaFilmes.Data.DAL
{
    public class DiretorDAL
    {
        string connectionString = @"Data Source =  DESKTOP-9D3IEDO\SQLEXPRESS01;
                                    Initial Catalog = db_PlataformaVideos; Integrated Security=True";

        public IEnumerable<Diretor> ObterTodosDiretores()
        {
            List<Diretor> lstDiretor = new List<Diretor>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.tbl_Diretor", connection);
                cmd.CommandType = CommandType.Text;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Diretor diretor = new Diretor();

                    diretor.Id = Convert.ToInt32(reader["Id"]);
                    diretor.Nome = reader["Nome"].ToString();

                    lstDiretor.Add(diretor);
                }
                connection.Close();
                return lstDiretor;
            }
        }
    

        public Diretor ObterDiretorPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Diretor diretor = new Diretor();

                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.tbl_Diretor WHERE Id =" + id, connection);
                cmd.CommandType = CommandType.Text;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    diretor.Id = Convert.ToInt32(reader["Id"]);
                    diretor.Nome = reader["Nome"].ToString();
                }
                return diretor;
            }
        }

        
        public void AdicionarDiretor(Diretor diretor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd =  new SqlCommand("INSERT INTO dbo.tbl_Diretor(Nome) VALUES (@Nome)", connection);

                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", diretor.Nome);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }


        public void AtualizarDiretor(Diretor diretor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UPDATE dbo.tbl_Diretor set Nome=@Nome WHERE Id = @Id", connection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", diretor.Id);
                cmd.Parameters.AddWithValue("@Nome", diretor.Nome);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }


        public void DeletarDiretor(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM dbo.tbl_Diretor WHERE Id = @id",connection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", id);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}

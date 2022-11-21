

using MODELS;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Security.Cryptography;

namespace DAL
{
    public class EleitorDAL
    {
        public void Inserir(Eleitor _eleitor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "INSERT INTO Eleitor(Titulo, Nome,Votou) VALUES(@Titulo, @Nome,@Votou)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Titulo", _eleitor.TituloEleitor);
                cmd.Parameters.AddWithValue("@Nome", _eleitor.Nome);
                cmd.Parameters.AddWithValue("@Votou", _eleitor.Votou);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public void Excluir(int _id)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "DELETE FROM Eleitor WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id",_id);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }


        }

        public void Excluir(Eleitor _eleitor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "DELETE FROM Eleitor WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", _eleitor.Id);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Eleitor _eleitor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "UPDATE  Eleitor SET Titulo = @Titulo, Nome = @Nome,Votou = @Votou, Id = @Id WHERE Id = @Id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Titulo", _eleitor.TituloEleitor);
                cmd.Parameters.AddWithValue("@Nome", _eleitor.Nome);
                cmd.Parameters.AddWithValue("@Votou", _eleitor.Votou);
                cmd.Parameters.AddWithValue("@Id", _eleitor.Id);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public  DataTable BuscarPorTitulo(string _tituloEleitor)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                da.SelectCommand = cn.CreateCommand();
                da.SelectCommand.CommandText = "SELECT  Id ,Nome , Titulo as tituloEleitor, Votou FROM Eleitor WHERE Titulo LIKE @Titulo";
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.AddWithValue("@Titulo", "%" + _tituloEleitor + "%");
                cn.Open();
                da.Fill(dt);
                return dt;
            }
            finally
            {
               cn.Close();
            }
        }

        public DataTable BuscarPorNome(string _nome)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                da.SelectCommand = cn.CreateCommand();
                da.SelectCommand.CommandText = "SELECT  Id ,Nome , Titulo as tituloEleitor, Votou FROM Eleitor WHERE Nome = @Nome" ;
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.AddWithValue("@Nome", _nome);
                cn.Open();
                da.Fill(dt);
                return dt;
            }
            finally
            {
                cn.Close();
            }
        }

        public object BuscarPorId(int _id)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                da.SelectCommand = cn.CreateCommand();
                da.SelectCommand.CommandText = "SELECT  Id ,Nome , Titulo as tituloEleitor, Votou FROM Eleitor WHERE Id = @Id";
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                da.Fill(dt);
                return dt;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

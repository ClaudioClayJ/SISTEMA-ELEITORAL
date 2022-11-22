

using MODELS;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace DAL
{
    public class CandidatoDAL
    {
        public void Inserir(Candidato _candidato)
        {
            {

                SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
                SqlCommand cmd = cn.CreateCommand();
                try
                {
                cmd.CommandText = "INSERT INTO Candidato(Numero, Nome) VALUES(@Numero, @Nome)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Numero", _candidato.Numero);
                cmd.Parameters.AddWithValue("@Nome", _candidato.Nome);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                }
                finally
                {

                cmd.Connection.Close();
               
                }
            }
        }

        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "DELETE FROM Candidato WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", _id);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(Candidato _candidato)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "DELETE FROM Candidato WHERE Numero = @Numero";
                cmd.Parameters.AddWithValue("@Numero", _candidato.Numero);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Candidato _candidato)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "UPDATE Candidato SET Numero = @Numero, Nome = @Nome WHERE Id = @Id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Numero", _candidato.Numero);
                cmd.Parameters.AddWithValue("@Nome", _candidato.Nome);
                cmd.Parameters.AddWithValue("@Id", _candidato.Id);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

            }
            finally
            {

                cmd.Connection.Close();

            }
        }
        public DataTable BuscarPorNumero(int _numero)
        {

            SqlDataAdapter da = new SqlDataAdapter();

            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                da.SelectCommand = cn.CreateCommand();
                da.SelectCommand.CommandText = "SELECT  Id ,Nome , Numero FROM Candidato WHERE Numero LIKE @Numero";
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.AddWithValue("@Numero","%" + _numero + "%");
                cn.Open();
                da.Fill(dt);
                return dt;
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable BuscarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter();

            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                da.SelectCommand = cn.CreateCommand();
                da.SelectCommand.CommandText = "SELECT  Id ,Nome , Numero FROM Candidato ";
                da.SelectCommand.CommandType = CommandType.Text;
   
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
                da.SelectCommand.CommandText = "SELECT  Id ,Nome , Numero FROM Candidato WHERE Nome LIKE @Nome";
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.AddWithValue("@Nome","%" + _nome + "%");
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
                da.SelectCommand.CommandText = "SELECT  Id ,Nome , Numero FROM Candidato WHERE Id = @Id";
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
